using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Worlds
{
    class WorldInformation
    {
        public string Name { get; set; }
        public int PlayersOnline { get; set; }
        public OnlineRecord OnlineRecord { get; set; }
        public string CreationDate { get; set; }
        public string Location { get; set; }
        public string PvpType { get; set; }
        public string PremiumType { get; set; }
        public List<string> WorldQuestTitles { get; set; }
        public string BattleyeStatus { get; set; }

        [JsonProperty("Game World Type:")]
        public string GameWorldType { get; set; }
    }
}
