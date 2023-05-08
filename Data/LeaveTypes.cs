namespace MarketMentor.Data
{
    public class LeaveTypes:BaseEntity
    {   
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
