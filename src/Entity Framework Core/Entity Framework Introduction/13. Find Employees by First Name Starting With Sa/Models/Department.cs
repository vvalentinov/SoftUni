namespace _13._Find_Employees_by_First_Name_Starting_With_Sa.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
