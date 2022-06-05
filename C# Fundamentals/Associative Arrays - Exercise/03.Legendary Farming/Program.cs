namespace _03.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;

            bool hasToBreak = false;

            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (material == "fragments" || material == "motes" || material == "shards")
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }
                }
            }

          
            Console.WriteLine($"shards: {keyMaterials["shards"]}");
            Console.WriteLine($"motes: {keyMaterials["motes"]}");
            Console.WriteLine($"fragments: {keyMaterials["fragments"]}");
            
            foreach (var kvp in junkMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
