using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Text;

using Course.Entities;


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
                p.InfoChar(p.NomeChar);
                Console.WriteLine(p);

            } else if (select == "world")
            {
                Console.Write("Digite o nome do mundo: ");
                string nomeMundo = Console.ReadLine();
                WordRecurses w = new WordRecurses(nomeMundo);
                w.InfoWorld(w.NomeWorld);
                Console.WriteLine(w);
            } else
            {

            }
        }
    }
}
