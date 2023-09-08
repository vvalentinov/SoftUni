namespace _06._Adding_a_New_Address_and_Updating_Employee
{
    using _06._Adding_a_New_Address_and_Updating_Employee.Data;
    using _06._Adding_a_New_Address_and_Updating_Employee.Models;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(AddNewAddressToEmployee(context));
        }
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(address);

            Employee employee = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");

            address.Employees.Add(employee);

            employee.AddressId = address.AddressId;

            context.SaveChanges();

            var addresses = context.Employees.Select(x => new
            {
                x.Address.AddressId,
                x.Address.AddressText
            }).OrderByDescending(x => x.AddressId).Take(10);

            StringBuilder builder = new StringBuilder();

            foreach (var item in addresses)
            {
                builder.AppendLine($"{item.AddressText}");
            }



            return builder.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                                   .Where(x => x.Department.Name == "Research and Development")
                                   .Select(x => new
                                   {
                                       x.FirstName,
                                       x.LastName,
                                       x.Department.Name,
                                       x.Salary
                                   }).OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName).ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Name} - ${employee.Salary:f2}");
            }

            return builder.ToString().TrimEnd();
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