using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueHUB_infrastructure
{
    public class Game
    {
        public int Id { get; set; }
        public Team Home { get; set; }
        public Team Guest { get; set; }
        public Referee Referee { get; set; }
        public int HomeScore { get; set; }
        public int GuestScore { get; set; }
        public DateTime date { get; set; }
    }
}
