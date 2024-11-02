namespace ManagementCabin
{
    public class Cabin
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        static int count;
        public double Price { get; set; }
        public bool status { get;  set; }

        public Cabin(int id, string name, double price)
        {
            Id=count++;
            Name=name;
            Price=price;
            status=true;
        }

        public Cabin() { }

        public void UpDateStatus() => status = !status;
    }
}
