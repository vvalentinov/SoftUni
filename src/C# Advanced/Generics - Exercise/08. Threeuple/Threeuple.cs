namespace _08._Threeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public Threeuple(TFirst first, TSecond second, TThird third)
        {
            ItemOne = first;
            ItemTwo = second;
            ItemThree = third;
        }
        public TFirst ItemOne { get; set; }
        public TSecond ItemTwo { get; set; }
        public TThird ItemThree { get; set; }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo} -> {ItemThree}";
        }
    }
}
