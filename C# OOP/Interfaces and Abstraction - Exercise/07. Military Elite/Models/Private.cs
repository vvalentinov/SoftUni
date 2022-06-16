namespace _07._Military_Elite.Models
{
    using _07._Military_Elite.Interfaces;

    public class Private : ISoldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, double salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}
