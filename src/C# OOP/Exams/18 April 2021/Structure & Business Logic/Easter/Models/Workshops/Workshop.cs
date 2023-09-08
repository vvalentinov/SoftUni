namespace Easter.Models.Workshops
{
    using Easter.Models.Bunnies.Contracts;
    using Easter.Models.Dyes.Contracts;
    using Easter.Models.Eggs.Contracts;
    using Easter.Models.Workshops.Contracts;

    public class Workshop : IWorkshop
    {
        public void Color(IEgg egg, IBunny bunny)
        {
            foreach (IDye dye in bunny.Dyes)
            {
                this.ColorEgg(bunny, dye, egg);
                if (egg.IsDone())
                {
                    break;
                }
            }
        }

        private void ColorEgg(IBunny bunny, IDye dye, IEgg egg)
        {
            while (bunny.Energy > 0 && egg.IsDone() == false && dye.IsFinished() == false)
            {
                egg.GetColored();
                bunny.Work();
                dye.Use();
            }
        }
    }
}
