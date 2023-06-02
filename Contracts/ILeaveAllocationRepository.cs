using MarketMentor.Data;
using MarketMentor.Models;

namespace MarketMentor.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocations>
    {
        Task LeaveAllocation(int LeaveTypeId);
        Task<bool> AllocationExist(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM model);

    }
}
