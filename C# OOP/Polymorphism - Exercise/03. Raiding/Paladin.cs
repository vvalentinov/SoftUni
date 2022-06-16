namespace _03._Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name, 100)
        {
        }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
