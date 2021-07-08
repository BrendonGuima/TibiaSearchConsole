using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args){
            while (true)
            {
                //Logo
                Menu m = new Menu();
                m.L();
                //Menu
                m.M();

                int select;

                while (!(int.TryParse(Console.ReadLine(), out select)))
                {
                    Console.Write("Digite novamente: ");
                }

                switch (select)
                {
                    case 1:
                        Console.Write("Digite o nome do personagem: ");
                        string nomeChar = Console.ReadLine();
                        Console.WriteLine("╚═══════════════════════════════════════════════╝");
                        PersonRecurses p = new PersonRecurses(nomeChar);
                        p.InfoPerson(p.NomeChar);
                        Console.Clear();
                        m.L();
                        Console.WriteLine(p);
                        Console.Write("  Last Login: ");
                        Console.WriteLine(p.LastLogin());
                        Console.WriteLine(p.Achievement());
                        Console.WriteLine(p.Deaths());
                        while (!(int.TryParse(Console.ReadLine(), out select)))
                        {
                            Console.Write("Digite novamente: ");
                        }
                        break;
                    case 2:
                        Console.Write("Digite o nome do mundo: ");
                        string nomeMundo = Console.ReadLine();
                        WorldRecurses w = new WorldRecurses(nomeMundo);
                        w.InfoWorld(w.NomeWorld);
                        Console.Clear();
                        m.L();
                        Console.WriteLine(w);
                        Console.WriteLine(w.WorldQuest());
                        Console.WriteLine(w.POnline());
                        while (!(int.TryParse(Console.ReadLine(), out select)))
                        {
                            Console.Write("Digite novamente: ");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o nome da guild: ");
                        string nomeGuild = Console.ReadLine().ToLower();
                        GuildsRecurses g = new GuildsRecurses(nomeGuild);
                        g.InfoGuild(g.NomeGuild);
                        Console.WriteLine(g);
                        break;
                }
                Console.Clear();
            }
        }
    }
}

