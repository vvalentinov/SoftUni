namespace _09._Pokemon_Trainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
