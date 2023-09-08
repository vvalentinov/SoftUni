namespace _10._Departments_with_More_Than_5_Employees.Models
{
    public partial class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
