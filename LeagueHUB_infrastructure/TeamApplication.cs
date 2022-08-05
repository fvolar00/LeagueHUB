using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueHUB_infrastructure
{
    public class TeamApplication
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }
        public Coach Coach { get; set; }
        //public List<string> Player { get; set; }??
        //public string Coach { get; set; }??

    }
}
