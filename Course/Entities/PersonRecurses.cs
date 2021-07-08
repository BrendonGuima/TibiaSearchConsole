using System;
using System.Net;
using Newtonsoft.Json;
using Course.Entities.Person;

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

        public void InfoPerson(string nomeChar)
        {
            string url = $"https://api.tibiadata.com/v2/characters/{NomeChar}.json";
            //Baixa o arquivo json da api.
            WebClient webClient = new WebClient();
            string read = webClient.DownloadString(url);
            
            //vai ler o arquivo json.
            PersonMain PersonConvert = JsonConvert.DeserializeObject<PersonMain>(read);
            Ro = PersonConvert;
            
        }

        public string Deaths()
        {
            Console.WriteLine("╔═══════════════════════════════════DEATHS════════════════════════════════════════╗");
            foreach (var item in Ro.characters.deaths)
            {
                Console.WriteLine("   Death in level " + item.level + " | " + item.reason + " in " + DateTime.Parse(item.date.date).ToString("dd/MM/yyyy HH:mm:ss"));
            }
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗");
            Console.WriteLine("║ 1 - Return                                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            return "";
        }

        public string LastLogin()
        {
            foreach (var item in Ro.characters.data.last_login)
            {
                Console.WriteLine(DateTime.Parse(item.date).ToString("dd/MM/yyyy HH:mm:ss"));
            }
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
            return "";
        }

        public string Achievement()
        {
            Console.WriteLine("╔═══════════════════════════Achievement's═══════════════════════════════╗");
            foreach (var item in Ro.characters.achievements)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
            return "";
        }

        public override string ToString()
        {
            return "╔══════════════════════════════════CHAR INFO══════════════════════════════════════╗"
            + "\n  Name: " + Ro.characters.data.name
            + "\n  Sex: " + Ro.characters.data.sex
            + "\n  Level: " + Ro.characters.data.level
            + "\n  Vocation: " + Ro.characters.data.vocation
            + "\n  Residence: " + Ro.characters.data.residence
            + "\n  World: " + Ro.characters.data.world
            + "\n  Account Status: " + Ro.characters.data.account_status
            + "\n  Status: " + Ro.characters.data.status;
        }
    }
}

