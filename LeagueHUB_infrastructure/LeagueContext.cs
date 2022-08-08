using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueHUB_infrastructure
{
    public class LeagueContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Participant> Participants { get; set; }

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
