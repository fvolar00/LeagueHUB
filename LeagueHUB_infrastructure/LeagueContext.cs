using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueHUB_infrastructure
{
    public class LeagueContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamApplication> TeamApplication { get; set; }
        public DbSet<Referee> Referee { get; set; }
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database" +
            "=LeagueHUB; Integrated Security = True; Trusted_Connection =" +
            "true; MultipleActiveResultSets = True");
        }

    }
}
