using System;

namespace LeagueHUB_infrastructure
{
    public abstract class Participant
    {
        public int Id { get; set; }
        public Team? Team { get; set; }
        public int TeamId { get; set; }
        public string? Name { get; set; }

    }

    public class Coach : Participant
    {
    }

    public class Player : Participant
    {
    }
}
