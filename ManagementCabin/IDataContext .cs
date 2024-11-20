namespace ManagementCabin
{
    public interface IDataContext
    {
        public List<Castomer> Castomers { get; set; }
        public List<Cabin> Cabins { get; set; }
        public List<Order> Orders { get; set; }
    }
}
