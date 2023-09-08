namespace _04._Employees_with_Salary_Over_50_000.Models
{
    public partial class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
