using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APpz_lw1._3
{
    public class Menu
    {
        public void start()
        {
            bool check1 = false;
            while (!check1)
            {
                Console.Clear();
                Console.Write("Choose game (enter number):\n1. Monopoly\n2. Checkers\n3. Backgammon\n4. Chess\n");
                string game = Console.ReadLine();
                switch (game)
                {
                    case "1": monopoly(); check1 = true; break;
                    case "2": checkers(); check1 = true; break;
                    case "3": backgammon(); check1 = true; break;
                    case "4": chess(); check1 = true; break;
                    default: Console.Write("Incorrect option. Try again.\n"); Console.Read(); break;
                }
            }
        }
        public void monopoly()
        {
            bool check = false;
            string message = "";
            while (!check)
            {
                Console.Clear();
                Console.Write(message + "How many players?");
                int players = Convert.ToInt32(Console.ReadLine());
                if (players > 1 && players < 7)
                {
                    Monopoly monopoly = new Monopoly(players);
                    monopoly.addAttributes(false, players, false, 2);
                    check = true;
                    for (int i = 0; i < players; i++)
                    {
                        Console.Write("Enter name for " + (i + 1) + " player: ");
                        string name = Console.ReadLine();
                        monopoly.players.Add(new Player(name));
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < monopoly.players.Count; j++)
                        {
                            Console.Write("\t" + monopoly.players[j].Name + " is going to make move. Press enter.");
                            Console.Read();
                            Console.Write("Player is on the " + monopoly.makeMove(j) + " position.\n");
                            Console.Read();
                        }
                    }
                    Console.WriteLine("Game is over.");
                    Console.Read();
                }
                else message = "Only 2-7 players can take part. Try again.\n";
            }
        }
        public void checkers()
        {
            bool check = false;
            string message = "";
            while (!check)
            {
                Console.Clear();
                Console.Write(message + "How many players?");
                int players = Convert.ToInt32(Console.ReadLine());
                if (players == 2)
                {
                    check = true;
                    Checkers checkers = new Checkers(players);
                    checkers.addAttributes(false, 0, true, 0);
                    for (int i = 0; i < players; i++)
                    {
                        Console.Write("Enter name for " + (i + 1) + " player: ");
                        string name = Console.ReadLine();
                        checkers.players.Add(new Player(name));
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < checkers.players.Count; j++)
                        {
                            Console.Write("\t" + checkers.players[j].Name + " is going to make move. Press enter.");
                            Console.Read();
                            Console.Write("Player made move by " + checkers.makeMove(j) + " checker.\n");
                            Console.Read();
                        }
                    }
                    Console.WriteLine("Game is over.");
                    Console.Read();
                }
                else message = "Only 2 players can take part. Try again.\n";
            }
        }
        public void backgammon()
        {
            bool check = false;
            string message = "";
            while (!check)
            {
                Console.Clear();
                Console.Write(message + "How many players?");
                int players = Convert.ToInt32(Console.ReadLine());
                if (players == 2)
                {
                    check = true;
                    Backgammon backgammon = new Backgammon(players);
                    backgammon.addAttributes(false, 0, true, 2);
                    for (int i = 0; i < players; i++)
                    {
                        Console.Write("Enter name for " + (i + 1) + " player: ");
                        string name = Console.ReadLine();
                        backgammon.players.Add(new Player(name));
                    }
                    while (backgammon.getSum(0) < 270 && backgammon.getSum(1) < 270)
                    {
                        for (int j = 0; j < backgammon.players.Count; j++)
                        {
                            Console.Write("\t" + backgammon.players[j].Name + " is going to make move. Press enter.");
                            Console.Read();
                            Console.Write("Player rolled cubs and earn " + backgammon.makeMove(j) + " points. Total points: " + backgammon.getSum(j) + " \n");
                            Console.Read();
                        }
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        if (backgammon.getSum(i) >= 270)
                            Console.Write(backgammon.players[i].Name + " won. Congratulations!\n");
                    }
                    Console.WriteLine("Game is over.");
                    Console.Read();
                }
                else message = "Only 2 players can take part. Try again.\n";
            }
        }
        public void chess()
        {
            bool check = false;
            string message = "";
            while (!check)
            {
                Console.Clear();
                Console.Write(message + "How many players?");
                int players = Convert.ToInt32(Console.ReadLine());
                if (players == 2)
                {
                    check = true;
                    Chess chess = new Chess(players);
                    chess.addAttributes(true, 0, false, 0);
                    for (int i = 0; i < players; i++)
                    {
                        Console.Write("Enter name for " + (i + 1) + " player: ");
                        string name = Console.ReadLine();
                        chess.players.Add(new Player(name));
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < chess.players.Count; j++)
                        {
                            Console.Write("\t" + chess.players[j].Name + " is going to make move. Press enter.");
                            Console.Read();
                            Console.Write("Player made move by " + ((Figure)chess.attributes[chess.makeMove(j)]).Type + " .\n");
                            Console.Read();
                        }
                    }
                    Console.WriteLine("Game is over.");
                    Console.Read();
                }
                else message = "Only 2 players can take part. Try again.\n";
            }
        }
    }
}
