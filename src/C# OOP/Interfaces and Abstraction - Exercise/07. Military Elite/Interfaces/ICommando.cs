namespace _07._Military_Elite.Interfaces
{
    using _07._Military_Elite.Models;

    public interface ICommando
    {
        ICollection<Mission> Missions { get; }
    }
}
