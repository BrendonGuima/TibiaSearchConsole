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
        {   //Logo
            Console.WriteLine(@" _________  ___  ________  ___  ________          ________  _______   ________  ________  ________  ___  ___     
|\___   ___\\  \|\   __  \|\  \|\   __  \        |\   ____\|\  ___ \ |\   __  \|\   __  \|\   ____\|\  \|\  \    
\|___ \  \_\ \  \ \  \|\ /\ \  \ \  \|\  \       \ \  \___|\ \   __/|\ \  \|\  \ \  \|\  \ \  \___|\ \  \\\  \   
     \ \  \ \ \  \ \   __  \ \  \ \   __  \       \ \_____  \ \  \_|/_\ \   __  \ \   _  _\ \  \    \ \   __  \  
      \ \  \ \ \  \ \  \|\  \ \  \ \  \ \  \       \|____|\  \ \  \_|\ \ \  \ \  \ \  \\  \\ \  \____\ \  \ \  \ 
       \ \__\ \ \__\ \_______\ \__\ \__\ \__\        ____\_\  \ \_______\ \__\ \__\ \__\\ _\\ \_______\ \__\ \__\
        \|__|  \|__|\|_______|\|__|\|__|\|__|       |\_________\|_______|\|__|\|__|\|__|\|__|\|_______|\|__|\|__|
                                                    \|_________|                                                 ");


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
            Console.ReadLine();
        }
    }
}
