using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3__Arena_Fighter
{

    // make sure that you use relational maping (entities) between your classes :)
    class Program
    {
        static void Main(string[] args)
        {
            List<Battle> history = new List<Battle>();
            bool live = true;
            do
            {
                Console.WriteLine("                                    Welcome to ARENA FIGHTER");
                Console.WriteLine("New Game : press 1");

                Console.WriteLine("Exit Game : press q");
                string Answer = "";
                Answer = Console.ReadLine();
                const string NewGame = ("1");
                const string Quit = ("q");
                bool alive = true;



                if (Answer == NewGame)
                {
                    Console.WriteLine("Are you ready to enter the Blood Pit and create your gladiator ? Please Enter the name of your Gladiator!!!");


                    Character Player = new Character(Console.ReadLine()); //*fixed* problem 1# here it  allways makes a new player character instead of keeping the last one if he is alive.
                    do
                    {
                        Console.WriteLine("Loading...");
                        Console.WriteLine("Press any key to start a new Battle ..");
                        Console.ReadKey();
                        Character AIGladiator = new Character();



                        AIGladiator.Status();
                        Console.WriteLine("V.S.\n\n");
                        Player.Status();

                        Battle battle = new Battle();
                        history.Add(battle);
                        battle.ToBattle(Player, AIGladiator);

                        if (Player.HP <= 0)
                        {
                            Console.WriteLine($"{AIGladiator.Name} won, you lost\n");
                            Player.Status();
                            Console.WriteLine($"The number of slain foes by your hand were {Player.Victories}");
                            foreach (var item in history)
                            {
                                Console.WriteLine($"{item.Player.Name} vs {item.AIGladiator.Name}");
                            }
                            Console.WriteLine("  ");
                            Console.WriteLine("GAME OVER");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (AIGladiator.HP <= 0)
                        {
                            Console.WriteLine($"Congaratiolations {Player.Name} you won the battle");
                            Player.Victories++;
                            Console.WriteLine($"The number of slain foes by your hand were {Player.Victories}\n");
                            Console.WriteLine("What do you want to do, continue in the Blood Pit to win more Prestige (press y ) or do you want to retire with the prestige you have and leave the Blood Pit alive (Press x)");
                        }
                        //  make it so if the player survives he can choose to retire or to continue in the Blood Pit
                        string Answer2 = null;
                        Answer2 = Console.ReadLine();
                        string Continue = ("y");
                        string Retire = ("x");

                        if (Answer2 == Continue)
                        {
                            // Sends me back to the begging of the while loop in line 37
                        }
                        else if (Answer2 == Retire)
                        {
                            Player.Status();
                            Console.WriteLine($"The number of slain foes by your hand were {Player.Victories}");
                            foreach (var item in history) // From the list i made in the begining "List<Battle> history"
                            {
                                Console.WriteLine($"{item.Player.Name} vs {item.AIGladiator.Name}");
                            }
                            Console.WriteLine($"{Player.Name} has left the Boold Pit with {Player.Victories} kills , a brutal and fearless warrior who never looked back, Thank you for playing");
                            Console.ReadKey();
                            Environment.Exit(0);
                            //alive = false;
                        }
                    } while (alive);

                }



                else if (Answer == Quit)
                {
                    Console.WriteLine("Thank you for playing, comeback anytime.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The option you wrote was invalid, please try again");

                }



            } while (live);
        }
    }
}
