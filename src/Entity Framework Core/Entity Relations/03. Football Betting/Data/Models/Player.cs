namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        public Player()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        [Required]
        public bool IsInjured { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [Required]
        public int SquadNumber { get; set; }

        [Required]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}
