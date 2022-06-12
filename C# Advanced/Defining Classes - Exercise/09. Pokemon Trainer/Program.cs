namespace _09._Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Tournament")
                {
                    break;
                }
                string[] parts = line.Split(new char[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool trainerExist = CheckTrainers(trainers, trainerName);
                if (trainerExist)
                {
                    Trainer trainer = trainers.Where(x => x.Name == trainerName).First();
                    trainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }

            }

            while (true)
            {
                string element = Console.ReadLine();
                if (element == "End")
                {
                    break;
                }
                for (int i = 0; i < trainers.Count; i++)
                {
                    Trainer trainer = trainers[i];
                    List<Pokemon> pokemons = trainer.Pokemons.Where(x => (x.Element == element)).ToList();
                    if (pokemons.Count == 0)
                    {
                        ReducePokemonHealth(trainer);
                    }
                    else
                    {
                        trainer.Badges += 1;
                    }
                }
            }
            List<Trainer> trainersSorted = trainers.OrderByDescending(x => x.Badges).ToList();
            foreach (Trainer trainer in trainersSorted)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
        private static bool CheckTrainers(List<Trainer> trainers, string trainerName)
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Name == trainerName)
                {
                    return true;
                }
            }
            return false;
        }

        private static void ReducePokemonHealth(Trainer trainer)
        {
            for (int i = 0; i < trainer.Pokemons.Count; i++)
            {
                trainer.Pokemons[i].Health -= 10;
                if (trainer.Pokemons[i].Health <= 0)
                {
                    trainer.Pokemons.RemoveAt(i);
                }
            }
        }
    }
}
