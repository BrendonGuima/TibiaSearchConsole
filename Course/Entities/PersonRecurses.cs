using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace Course.Entities
{
     class PersonRecurses
    {
        public string NomeChar { get; set; }
        public Root Ro { get; set; }


        public PersonRecurses(string nomeChar){
            NomeChar = nomeChar;
        }

        public void InfoChar(string nomeChar)
        {
            string url = "https://api.tibiadata.com/v2/characters/" + NomeChar + ".json";
            //Baixa o arquivo json da api.
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, "char.json");

            //vai ler o arquivo json.
            string patch = @"D:\Projetos c#\Aprendizagem\Course\Course\bin\Debug\netcoreapp3.1\char.json";
            string sr = File.ReadAllText(patch);

            //vai Deseriar o arquivo

            Root root = JsonConvert.DeserializeObject<Root>(sr);

            Ro = root;
        }

        public override string ToString()
        {
            return "-------Char Info-------\n"
                + "Name: " + Ro.Characters.Data.name
                + "\nSex: " + Ro.Characters.Data.sex
                + "\nLevel: " + Ro.Characters.Data.level
                + "\nVocation: " + Ro.Characters.Data.vocation
                + "\nResidence: " + Ro.Characters.Data.residence
                + "\nWorld: " + Ro.Characters.Data.world
                + "\nAccount Status: " + Ro.Characters.Data.account_status
                + "\nStatus: " + Ro.Characters.Data.status
                + "\n-------Thanks-------";
        }
    }
}
