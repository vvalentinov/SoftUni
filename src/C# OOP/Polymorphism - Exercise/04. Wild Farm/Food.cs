namespace _04._Wild_Farm
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; set; }
    }
}
