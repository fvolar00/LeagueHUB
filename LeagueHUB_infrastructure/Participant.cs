using System;

namespace LeagueHUB_infrastructure
{
    public abstract class Participant
    {
        public int Id { get; set; }
        public Team Team { get; set; }

    }

    public class Coach : Participant
    {
        public int CoachId { get; set; }
    }

    public class Player : Participant
    {
        public int PlayerId { get; set; }
    }
}
