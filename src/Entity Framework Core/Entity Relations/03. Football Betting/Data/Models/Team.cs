namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public Team()
        {
            this.HomeGames = new HashSet<Game>();
            this.AwayGames = new HashSet<Game>();
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int TeamId { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        public string Initials { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        public int PrimaryKitColorId { get; set; }
        public Color PrimaryKitColor { get; set; }

        [Required]
        public int SecondaryKitColorId { get; set; }
        public Color SecondaryKitColor { get; set; }

        [Required]
        public int TownId { get; set; }
        public Town Town { get; set; }

        public virtual ICollection<Game> HomeGames { get; set; }
        public virtual ICollection<Game> AwayGames { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
