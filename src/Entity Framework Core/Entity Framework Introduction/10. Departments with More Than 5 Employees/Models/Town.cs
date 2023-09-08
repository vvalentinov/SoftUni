namespace _10._Departments_with_More_Than_5_Employees.Models
{
    public partial class Town
    {
        public Town()
        {
            Addresses = new HashSet<Address>();
        }

        public int TownId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
