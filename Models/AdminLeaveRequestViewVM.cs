using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MarketMentor.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name ="Total number of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name ="Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name ="Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name ="Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<ClientRequestViewModel> ClientRequests { get; set; }
    }
}
