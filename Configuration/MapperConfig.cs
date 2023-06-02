using AutoMapper;
using MarketMentor.Data;
using MarketMentor.Models;

namespace MarketMentor.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveTypes, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocations, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocations, EditLeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();
            CreateMap<LeaveRequest, ClientRequestViewModel>().ReverseMap();
        }
    }
}
