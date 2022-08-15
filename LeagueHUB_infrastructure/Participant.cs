using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueHUB_infrastructure
{
    public abstract class Participant
    {
        public Team? Team { get; set; }
        public int TeamId { get; set; }
        public string Name { get; set; }

    }
    public class Coach : Participant
    {
        public int Id { get; set; }
    }
    public class Player : Participant
    {
        public int Id { get; set; }
    }
}
