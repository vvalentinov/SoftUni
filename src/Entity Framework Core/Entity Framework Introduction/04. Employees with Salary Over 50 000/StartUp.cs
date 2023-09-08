namespace _04._Employees_with_Salary_Over_50_000
{
    using _04._Employees_with_Salary_Over_50_000.Data;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(GetEmployeesWithSalaryOver50000(context));
        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees
                                   .Where(x => x.Salary > 50000)
                                   .Select(x => new
                                   {
                                       x.FirstName,
                                       x.Salary
                                   }).OrderBy(x => x.FirstName).ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context.Employees
                                   .Select(x => new
                                   {
                                       x.EmployeeId,
                                       x.FirstName,
                                       x.MiddleName,
                                       x.LastName,
                                       x.JobTitle,
                                       x.Salary
                                   }).OrderBy(x => x.EmployeeId).ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}