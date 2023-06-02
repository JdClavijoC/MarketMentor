using AutoMapper;
using MarketMentor.Constant;
using MarketMentor.Contracts;
using MarketMentor.Data;
using MarketMentor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MarketMentor.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocations>, ILeaveAllocationRepository
    {
        private readonly ApplicationDBContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDBContext context, UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public Task<bool> AllocationExist(string employeeId, int leaveTypeId, int period)
        {
            return context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId).ToListAsync();
            var employee = await userManager.FindByIdAsync(employeeId);
            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);
            return employeeAllocationModel;
        }
        public async Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (allocations == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocations.EmployeeId);
            var model = mapper.Map<EditLeaveAllocationVM>(allocations);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocations.EmployeeId));
            return model;
        }


        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocations>();
            foreach (var employee in employees)
            {
                if (await AllocationExist(employee.Id, leaveTypeId, period)) continue;

                allocations.Add(new LeaveAllocations
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
            }
            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM model)
        {
            var leaveAllocations = await GetAsync(model.Id);
            if (leaveAllocations == null)
            {
                return false;
            }
            leaveAllocations.Period = model.Period;
            leaveAllocations.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocations);
            return true;
        }
    }
}
