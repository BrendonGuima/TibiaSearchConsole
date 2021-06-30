using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Worlds
{
    class World
    {
        public WorldInformation WorldInformation { get; set; }
        public List<PlayersOnline> PlayersOnline { get; set; }
    }
}
