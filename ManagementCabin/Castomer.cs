namespace ManagementCabin
{
    public class Castomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        static int count;
        public Castomer()
        {

        }
        public Castomer(string name, string phone)
        {
            id = count++;
            this.name = name;
            this.phone = phone;
        }
    }
}
