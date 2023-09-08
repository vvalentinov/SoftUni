namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Position
    {
        public Position()
        {
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int PositionId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
