using Course.Entities.Worlds;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;


namespace Course.Entities
{
    class WordRecurses
    {
        public string NomeWorld { get; set; }
        public WorldMain Wo { get; set; }


        public WordRecurses(string nomeWorld)
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

            //Conversão

            WorldMain wo = JsonConvert.DeserializeObject<WorldMain>(read);

            Wo = wo;
        }

        public override string ToString()
        {
            return "--------WORLDS--------"
                + Wo.World.WorldInformation.Name
                + Wo.World.WorldInformation.PlayersOnline;
               
        }
    }
}
