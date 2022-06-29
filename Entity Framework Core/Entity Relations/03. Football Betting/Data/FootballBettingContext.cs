namespace _03._Football_Betting.Data
{
    using _03._Football_Betting.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Football;Integrated Security=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(x => new { x.GameId, x.PlayerId });

            modelBuilder.Entity<Color>().HasMany(x => x.PrimaryKitTeams).WithOne(x => x.PrimaryKitColor).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Color>().HasMany(x => x.SecondaryKitTeams).WithOne(x => x.SecondaryKitColor).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Team>().HasMany(x => x.HomeGames).WithOne(x => x.HomeTeam).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>().HasMany(x => x.AwayGames).WithOne(x => x.AwayTeam).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}
