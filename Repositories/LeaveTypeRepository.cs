using MarketMentor.Contracts;
using MarketMentor.Data;

namespace MarketMentor.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveTypes>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
