namespace _06._Food_Shortage
{
    public class Pet : IPet
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
