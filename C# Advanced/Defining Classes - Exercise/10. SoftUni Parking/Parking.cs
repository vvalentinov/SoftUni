namespace _10._SoftUni_Parking
{
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }
        public int Count => this.cars.Count;//prop
        public string AddCar(Car car)
        {
            bool carExists = cars.Any(x => x.RegistrationNumber == car.RegistrationNumber);
            if (carExists)
            {
                return "Car with that registration number, already exists!";
            }
            if (capacity == cars.Count)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string RegistrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(car);
                return $"Successfully removed {RegistrationNumber}";
            }
        }
        public Car GetCar(string RegistrationNumber) => cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNumber in registrationNumbers)
            {
                Car car = cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);
                cars.Remove(car);
            }
        }
    }
}
