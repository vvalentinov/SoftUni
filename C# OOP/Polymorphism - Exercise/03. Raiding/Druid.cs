namespace _03._Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name, 80)
        {
        }

        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
