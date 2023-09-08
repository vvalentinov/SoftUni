namespace _02._Validation_Attributes
{
    using _02._Validation_Attributes.Models;

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(null, -1);

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}