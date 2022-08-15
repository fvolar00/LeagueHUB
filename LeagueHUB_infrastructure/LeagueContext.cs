using Microsoft.EntityFrameworkCore;

namespace LeagueHUB_infrastructure


{
    public class LeagueContext : DbContext
    {
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Referee> Referee { get; set; }
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database" +
            "=LeagueHUB; Integrated Security = True; Trusted_Connection =" +
            "true; MultipleActiveResultSets = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasOne(e => e.Home)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // <--

            modelBuilder.Entity<Game>()
                .HasOne(e => e.Guest)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // <--

           

        }
    }


}

