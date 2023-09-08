namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Color
    {
        public Color()
        {
            this.PrimaryKitTeams = new HashSet<Team>();
            this.SecondaryKitTeams = new HashSet<Team>();
        }

        [Key]
        public int ColorId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Team> PrimaryKitTeams { get; set; }

        public virtual ICollection<Team> SecondaryKitTeams { get; set; }
    }
}
