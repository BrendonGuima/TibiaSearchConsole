using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;

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

            //Baixar a API
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, "world.json");

            //Ler API
            string patch = @"D:\Projetos c#\Aprendizagem\Course\Course\bin\Debug\netcoreapp3.1\world.json";
            string read = File.ReadAllText(patch);
            Rootobject r = JsonConvert.DeserializeObject<Rootobject>(read);
            Wo = r;
        }

        public string POnline()
        {
            foreach (var item in Wo.world.players_online)
            {
                Console.WriteLine("Name: " + item.name + " - Vocation: " + item.vocation + " - Level: " + item.level);
            }
            return "";
        }

        public string WorldQuest()
        {
            foreach (var item in Wo.world.world_information.world_quest_titles)
            {
                Console.WriteLine(item);
            }
            return "";
        }

        public override string ToString()
        {
            return "---------------WORLD INFO---------------"
                  + "\nNome do mundo: " + Wo.world.world_information.name
                  + "\nPlayers Online: " + Wo.world.world_information.players_online
                  + "\nLocation: " + Wo.world.world_information.location
                  + "\nOnline Record: " + Wo.world.world_information.online_record.players + " - date: " + Wo.world.world_information.online_record.date.date
                  + "\nPvp Type: " + Wo.world.world_information.pvp_type;
                  
        }
    }
}

