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
        public int GamesPlayed { get; set; } = 0;
        public int Wins { get; set; }= 0;
        public int Draws { get; set; }=0;
        public int Losses { get; set; } = 0;
        public int GoalsScored { get; set; } = 0;
        public int GoalsConceded { get; set; } = 0;
        public List<Player>? Players { get; set; }
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
