using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueHUB_infrastructure
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }   
        public int Draws { get; set; }
        public int Losses { get; set; } 
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public List<Player> Players { get; set; }
        public Coach Coach { get; set; }


        public int goalDifference()
        {
            int gd = GoalsScored - GoalsConceded;
            return gd;
        }

        public int getPoints()
        {
            int p = Wins * 3 + Draws * 1;
            return p;
        }

    }
}
