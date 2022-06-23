namespace _12._Increase_Salaries
{
    using _12._Increase_Salaries.Data;
    using _12._Increase_Salaries.Models;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(IncreaseSalaries(context));
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            List<string> departments = new List<string>() { "Marketing", "Engineering", "Tool Design", "Information Services" };
            List<Employee> employees = context.Employees.Where(x => departments.Contains(x.Department.Name)).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;
            }

            StringBuilder builder = new StringBuilder();

            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).Select(x => new
            {
                x.Name,
                x.Description,
                x.StartDate
            }).OrderBy(x => x.Name).ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var project in projects)
            {
                builder.AppendLine($"{project.Name}");
                builder.AppendLine($"{project.Description}");
                builder.AppendLine($"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                                     .Where(x => x.Employees.Count() > 5)
                                     .Select(x => new
                                     {
                                         x.Name,
                                         x.Manager.FirstName,
                                         x.Manager.LastName,
                                         Employees = x.Employees
                                     })
                                     .OrderBy(x => x.Employees.Count())
                                     .ThenBy(x => x.Name)
                                     .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var department in departments)
            {
                builder.AppendLine($"{department.Name} – {department.FirstName} {department.LastName}");

                var employees = department.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

                foreach (var employee in employees)
                {
                    builder.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            Employee employee = context.Employees.FirstOrDefault(x => x.EmployeeId == 147);


            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            var projects = context.EmployeesProjects.Where(x => x.EmployeeId == 147).Select(x => new { x.Project.Name }).OrderBy(x => x.Name).ToList();

            foreach (var project in projects)
            {
                builder.AppendLine($"{project.Name}");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                                   .Select(x => new
                                   {
                                       x.AddressText,
                                       TownName = x.Town.Name,
                                       CountEmployees = x.Employees.Count()
                                   })
            .OrderByDescending(x => x.CountEmployees)
            .ThenBy(x => x.TownName)
            .ThenBy(x => x.AddressText)
            .Take(10)
            .ToList();

            StringBuilder builder = new StringBuilder();

            foreach (var address in addresses)
            {
                builder.AppendLine($"{address.AddressText}, {address.TownName} - {address.CountEmployees} employees");
            }

            return builder.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(x => x.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    EmployeeFirstName = x.FirstName,
                    EmployeeLastName = x.LastName,
                    ManagerFirstName = x.Manager.FirstName,
                    ManagerLastName = x.Manager.LastName,
                    Projects = x.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    })
                })
                .Take(10)
                .ToList();
            StringBuilder builder = new StringBuilder();
            foreach (var employee in employees)
            {
                builder.AppendLine($"{employee.EmployeeFirstName} {employee.EmployeeLastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                foreach (var project in employee.Projects)
                {
                    var endDate = project.EndDate.HasValue
                        ? project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                        : "not finished";
                    builder.AppendLine($"--{project.ProjectName} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {endDate}");
                }
            }
            return builder.ToString().TrimEnd();
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