namespace _07._Military_Elite.Interfaces
{
    public enum Corps
    {
        Airforces,
        Marines
    }
    public interface ISpecialisedSoldier
    {
        Corps Corps { get; }
    }
}
