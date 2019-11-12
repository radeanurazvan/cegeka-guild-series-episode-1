using System;

namespace Cegeka.Guild.Pokeverse.DAL.Entities
{
    public class Battle : Entity
    {
        public Pokemon Attacker { get; set; }

        public Pokemon Defender { get; set; }

        public DateTime StartedAt { get; set; }

        public Pokemon Winner { get; set; }

        public Pokemon Loser { get; set; }
    }
}