namespace _03._Employees_Full_Information
{
    using _03._Employees_Full_Information.Data;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(GetEmployeesFullInformation(context));
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