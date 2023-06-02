namespace MarketMentor.Models
{
    public class ClientOperationRequestViewModel
    {
        public ClientOperationRequestViewModel(List<LeaveAllocationVM> leaveAllocations, List<ClientRequestViewModel> clientRequests)
        {
            LeaveAllocations = leaveAllocations;
            ClientRequests = clientRequests;
        }

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<ClientRequestViewModel> ClientRequests { get; set; }
    }
}
