using MarketMentor.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketMentor.Models
{
    public class ClientRequestViewModel: LeaveRequestCreateVM
    {
        public int Id { get; set; }
        [Display(Name ="Date Requested")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Active")]
        public LeaveTypeVM LeaveType { get; set; }

        public bool? Approved { get; set; }
        public bool Canceled { get; set; }
        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
