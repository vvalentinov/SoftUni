namespace _06.Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Box
        {
            public Box(
                string serialNumber,
                string itemName,
                int itemQuantity,
                double itemPrice,
                double priceOneBox)
            {
                SerialNumber = serialNumber;
                Item = itemName;
                ItemQuantity = itemQuantity;
                ItemPrice = itemPrice;
                PriceForABox = priceOneBox;
            }
            public string SerialNumber { get; set; }
            public string Item { get; set; }
            public int ItemQuantity { get; set; }
            public double ItemPrice { get; set; }
            public double PriceForABox { get; set; }
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] arr = line.Split();
                string serialNumber = arr[0];
                string itemName = arr[1];
                int itemQuantity = int.Parse(arr[2]);
                double itemPrice = double.Parse(arr[3]);

                double priceOneBox = itemQuantity * itemPrice;

                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice, priceOneBox);

                boxes.Add(box);

                line = Console.ReadLine();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(n => n.PriceForABox).ToList();
            foreach (var box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
