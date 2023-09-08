namespace _03._Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name, 100)
        {
        }

        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
}
