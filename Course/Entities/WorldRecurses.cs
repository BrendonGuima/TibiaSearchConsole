using Newtonsoft.Json;
using System;
using System.Net;

namespace Course.Entities
{
    class WorldRecurses
    {
        public string NomeWorld { get; set; }
        Rootobject Wo { get; set; }


        public WorldRecurses(string nomeWorld)
        {
            NomeWorld = nomeWorld;
        }

        public void InfoWorld(string nomeWorld)
        {
            string url = $"https://api.tibiadata.com/v2/world/{NomeWorld}.json";

            //Baixar e lê a API
            WebClient webClient = new WebClient();
            string read = webClient.DownloadString(url);
            Rootobject WorldConvert = JsonConvert.DeserializeObject<Rootobject>(read);
            Wo = WorldConvert;
        }

        public string POnline()
        {
            Console.WriteLine("╔═════════════════Players Online════════════════════════════════════════════════════════════════╗");
            foreach (var item in Wo.world.players_online)
            {
                Console.WriteLine("  " + "Name: " + item.name + " - Vocation: " + item.vocation + " - Level: " + item.level);
            }
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗");
            Console.WriteLine("║ 1 - Return                                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            return "";
        }

        public string WorldQuest()
        {
            Console.WriteLine("╔═════════════════World Quest════════════════╗");
            foreach (var item in Wo.world.world_information.world_quest_titles)
            {
                Console.WriteLine("  " + item);
            }
            Console.WriteLine("╚════════════════════════════════════════════╝");
            return "";
        }

        public override string ToString()
        {
            return "╔══════════════════════World Info═════════════════════╗"
                  + "\n  World Name: " + Wo.world.world_information.name
                  + "\n  Players Online: " + Wo.world.world_information.players_online
                  + "\n  Location: " + Wo.world.world_information.location
                  + "\n  Online Record: " + Wo.world.world_information.online_record.players + " - date: " + DateTime.Parse(Wo.world.world_information.online_record.date.date).ToString("dd/MM/yyyy HH:mm:ss")
                  + "\n  Pvp Type: " + Wo.world.world_information.pvp_type
                  + "\n  BattleEye: " + Wo.world.world_information.battleye_status
                  + "\n  World Create: " + Wo.world.world_information.creation_date
                  + "\n╚═════════════════════════════════════════════════════╝";
                  
        }
    }
}

