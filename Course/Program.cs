using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Text;

using Course.Entities;
using Newtonsoft.Json.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            Console.Write("Escolha a opção de pesquisar Character, World ou Guild: ");
            string select = Console.ReadLine().ToLower();

            if (select == "character")
            {
                Console.Write("Digite o nome do personagem: ");
                string nomeChar = Console.ReadLine();
                PersonRecurses p = new PersonRecurses(nomeChar); 
                p.Download(p.NomeChar);
                Console.WriteLine(p);
                Console.Write("Last Login: ");
                Console.WriteLine( p.LastLogin());
                Console.WriteLine("----------------------------------------------Deaths----------------------------------------------");
                Console.WriteLine(p.Deaths());

            } else if (select == "world")
            {
                Console.Write("Digite o nome do mundo: ");
                string nomeMundo = Console.ReadLine();
                WorldRecurses w = new WorldRecurses(nomeMundo);
                w.InfoWorld(w.NomeWorld);
                Console.WriteLine(w);
                Console.WriteLine("------------Players Online------------");
                Console.WriteLine(w.POnline());
                Console.WriteLine("-------------World Quest-------------");
                Console.WriteLine(w.WorldQuest());

            } else
            {

            }
        }
    }
}
