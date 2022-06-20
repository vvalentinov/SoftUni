namespace Easter.Models.Dyes
{
    using Easter.Models.Dyes.Contracts;

    public class Dye : IDye
    {
        private int power;
        public Dye(int power)
        {
            this.Power = power;
        }
        public int Power
        {
            get
            {
                return this.power;
            }
            private set
            {
                if (value < 0)
                {
                    this.power = 0;
                }
                else
                {
                    this.power = value;
                }
            }
        }

        public bool IsFinished()
        {
            return this.power == 0;
        }

        public void Use()
        {
            this.power -= 10;
            if (this.power < 0)
            {
                this.power = 0;
            }
        }
    }
}
