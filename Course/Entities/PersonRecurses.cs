using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using Course.Entities.Person;
using Course.Entities;

namespace Course.Entities
{
    class PersonRecurses
    {
        public string NomeChar { get; set; }
        PersonMain Ro { get; set; }


        public PersonRecurses(string nomeChar)
        {
            NomeChar = nomeChar;
        }

        public void Download(string nomeChar)
        {
            string url = "https://api.tibiadata.com/v2/characters/" + NomeChar + ".json";
            //Baixa o arquivo json da api.
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, "char.json");

            //vai ler o arquivo json.
            string patch = @"D:\Projetos c#\Aprendizagem\Course\Course\bin\Debug\netcoreapp3.1\char.json";
            string r = File.ReadAllText(patch);
            PersonMain p = JsonConvert.DeserializeObject<PersonMain>(r);
            Ro = p;
            
        }

        public string Deaths()
        {
            foreach (var item in Ro.characters.deaths)
            {
                Console.WriteLine("Death in level " + item.level + " " + item.reason + " in " + item.date.date);
            }
            return "";
        }

        public string LastLogin()
        {
            foreach (var item in Ro.characters.data.last_login)
            {
                Console.WriteLine(item.date);
            }
            return "";
        }


        public override string ToString()
        {
            return "-------Char Info-------"
            + "\nName: " + Ro.characters.data.name
            + "\nSex: " + Ro.characters.data.sex
            + "\nLevel: " + Ro.characters.data.level
            + "\nVocation: " + Ro.characters.data.vocation
            + "\nResidence: " + Ro.characters.data.residence
            + "\nWorld: " + Ro.characters.data.world
            + "\nAccount Status: " + Ro.characters.data.account_status
            + "\nStatus: " + Ro.characters.data.status;
        }
    }
}

