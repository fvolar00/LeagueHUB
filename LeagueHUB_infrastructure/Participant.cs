using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueHUB_infrastructure
{
    public class Participant
    {
        public int Id { get; set; }
        public Team? Team { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }

    }
    [NotMapped]
    public class Coach : Participant
    {
    }
    [NotMapped]
    public class Player : Participant
    {
    }
}
