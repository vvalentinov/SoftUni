namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public Game()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
            this.Bets = new HashSet<Bet>();
        }

        [Key]
        public int GameId { get; set; }

        [Required]
        public decimal AwayTeamBetRate { get; set; }

        [Required]
        public int AwayTeamGoals { get; set; }

        [Required]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        [Required]
        public decimal DrawBetRate { get; set; }

        [Required]
        public decimal HomeTeamBetRate { get; set; }

        [Required]
        public int HomeTeamGoals { get; set; }

        [Required]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        [Required]
        public string Result { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
