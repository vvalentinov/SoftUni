namespace Easter.Core
{
    using Easter.Core.Contracts;
    using Easter.Models.Bunnies;
    using Easter.Models.Bunnies.Contracts;
    using Easter.Models.Dyes;
    using Easter.Models.Dyes.Contracts;
    using Easter.Models.Eggs;
    using Easter.Models.Eggs.Contracts;
    using Easter.Models.Workshops;
    using Easter.Repositories;
    using Easter.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;
        public Controller()
        {
            this.bunnies = new BunnyRepository();
            this.eggs = new EggRepository();
        }
        public string AddBunny(string bunnyType, string bunnyName)
        {
            IBunny bunny;
            if (bunnyType == nameof(HappyBunny))
            {
                bunny = new HappyBunny(bunnyName);
            }
            else if (bunnyType == nameof(SleepyBunny))
            {
                bunny = new SleepyBunny(bunnyName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidBunnyType);
            }
            this.bunnies.Add(bunny);
            return string.Format(OutputMessages.BunnyAdded, bunnyType, bunnyName);
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IBunny bunny = this.bunnies.FindByName(bunnyName);
            if (bunny == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentBunny);
            }
            IDye dye = new Dye(power);
            bunny.AddDye(dye);
            return string.Format(OutputMessages.DyeAdded, power, bunnyName);
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);
            this.eggs.Add(egg);
            return string.Format(OutputMessages.EggAdded, eggName);
        }

        public string ColorEgg(string eggName)
        {
            IEgg egg = this.eggs.FindByName(eggName);
            List<IBunny> preparedBunnies = this.bunnies.Models.Where(x => x.Energy >= 50).OrderByDescending(x => x.Energy).ToList();
            if (preparedBunnies.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }
            Workshop workshop = new Workshop();
            foreach (IBunny bunny in preparedBunnies)
            {
                workshop.Color(egg, bunny);
                if (bunny.Energy == 0)
                {
                    this.bunnies.Remove(bunny);
                }
                if (egg.IsDone())
                {
                    return string.Format(OutputMessages.EggIsDone, eggName);
                }
            }
            return string.Format(OutputMessages.EggIsNotDone, eggName);
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{this.eggs.Models.Where(x => x.IsDone()).Count()} eggs are done!");
            builder.AppendLine("Bunnies info:");
            foreach (IBunny bunny in this.bunnies.Models)
            {
                builder.AppendLine($"Name: {bunny.Name}");
                builder.AppendLine($"Energy: {bunny.Energy}");
                builder.AppendLine($"Dyes: {bunny.Dyes.Where(x => x.IsFinished() == false).Count()} not finished");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
