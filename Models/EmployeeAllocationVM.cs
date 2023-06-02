using MarketMentor.Data;

namespace MarketMentor.Models
{
    public class EmployeeAllocationVM:EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
