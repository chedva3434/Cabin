namespace ManagementCabin
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime dateOfOrder { get; set; }
        public int CastomerId { get; set; }
        public Cabin cabin { get; set; }
        static int count;
        
        public Order(DateTime dateOfOrder, int castomerId, Cabin c)
        {
            Id = count++;
            this.dateOfOrder = dateOfOrder;
            CastomerId = castomerId;
            this.cabin = c;
            c.UpDateStatus();
        }

        public Order() { }
    }
}
