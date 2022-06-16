namespace _04._Wild_Farm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string firstLine = Console.ReadLine();
                if (firstLine == "End")
                {
                    break;
                }
                string secondLine = Console.ReadLine();
                string[] tokensAnimal = firstLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string typeAnimal = tokensAnimal[0];
                Animal animal = null;
                string[] tokensFood = secondLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Food food = null;
                switch (tokensFood[0])
                {
                    case "Fruit":
                        food = new Fruit(int.Parse(tokensFood[1]));
                        break;
                    case "Vegetable":
                        food = new Vegetable(int.Parse(tokensFood[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(tokensFood[1]));
                        break;
                    case "Seeds":
                        food = new Seeds(int.Parse(tokensFood[1]));
                        break;
                }
                string foodType = food.GetType().Name;
                switch (typeAnimal)
                {
                    case "Owl":
                        animal = new Owl(tokensAnimal[1], double.Parse(tokensAnimal[2]), double.Parse(tokensAnimal[3]));
                        animals.Add(animal);
                        animal.ProduceSound();
                        if (foodType != "Meat")
                        {
                            Console.WriteLine($"Owl does not eat {foodType}!");
                            break;
                        }
                        animal.Weight += (food.Quantity * 0.25);
                        animal.FoodEaten += food.Quantity;
                        break;
                    case "Hen":
                        animal = new Hen(tokensAnimal[1], double.Parse(tokensAnimal[2]), double.Parse(tokensAnimal[3]));
                        animals.Add(animal);
                        animal.ProduceSound();
                        animal.Weight += (food.Quantity * 0.35);
                        animal.FoodEaten += food.Quantity;
                        break;
                    case "Mouse":
                        animal = new Mouse(tokensAnimal[1], double.Parse(tokensAnimal[2]), tokensAnimal[3]);
                        animals.Add(animal);
                        animal.ProduceSound();
                        if (foodType != "Vegetable" && foodType != "Fruit")
                        {
                            Console.WriteLine($"Mouse does not eat {foodType}!");
                            break;
                        }
                        animal.Weight += (food.Quantity * 0.10);
                        animal.FoodEaten += food.Quantity;
                        break;
                    case "Dog":
                        animal = new Dog(tokensAnimal[1], double.Parse(tokensAnimal[2]), tokensAnimal[3]);
                        animals.Add(animal);
                        animal.ProduceSound();
                        if (foodType != "Meat")
                        {
                            Console.WriteLine($"Dog does not eat {foodType}!");
                            break;
                        }
                        animal.Weight += (food.Quantity * 0.40);
                        animal.FoodEaten += food.Quantity;
                        break;
                    case "Cat":
                        animal = new Cat(tokensAnimal[1], double.Parse(tokensAnimal[2]), tokensAnimal[3], tokensAnimal[4]);
                        animals.Add(animal);
                        animal.ProduceSound();
                        if (foodType != "Vegetable" && foodType != "Meat")
                        {
                            Console.WriteLine($"Cat does not eat {foodType}!");
                            break;
                        }
                        animal.Weight += (food.Quantity * 0.30);
                        animal.FoodEaten += food.Quantity;
                        break;
                    case "Tiger":
                        animal = new Tiger(tokensAnimal[1], double.Parse(tokensAnimal[2]), tokensAnimal[3], tokensAnimal[4]);
                        animals.Add(animal);
                        animal.ProduceSound();
                        if (foodType != "Meat")
                        {
                            Console.WriteLine($"Tiger does not eat {foodType}!");
                            break;
                        }
                        animal.Weight += (food.Quantity * 1);
                        animal.FoodEaten += food.Quantity;
                        break;
                }


            }
            animals.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}