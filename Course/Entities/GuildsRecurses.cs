using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using Course.Entities.Guilds;
using Newtonsoft.Json;

namespace Course.Entities
{
    class GuildsRecurses
    {
        public string NomeGuild { get; set; }
        GuildsMain Gu { get; set; }

        public GuildsRecurses(string nomeGuild)
        {
            NomeGuild = nomeGuild;
        }

        public void InfoGuild(string nomeGuild)
        {
            string url = $"https://api.tibiadata.com/v2/guild/{NomeGuild}.json";

            WebClient webClient = new WebClient();
            string read = webClient.DownloadString(url);
            GuildsMain GuildConvert = JsonConvert.DeserializeObject<GuildsMain>(read);
            Gu = GuildConvert;
        }

        public override string ToString()
        {
            return "Name: " + Gu.guild.data.name;

        }
    }
}
