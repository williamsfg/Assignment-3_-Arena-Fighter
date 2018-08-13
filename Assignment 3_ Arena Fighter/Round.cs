using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3__Arena_Fighter
{
    class Round
    {
        static Random random = new Random();

        int playerDice;
        int AIDice;

        public void Fight(Character player, Character AIGladiator)
        {
            playerDice = DiceRoll();
            AIDice = DiceRoll();
            

            if ((player.Strenght + playerDice) > (AIGladiator.Strenght + AIDice))
            {
                Console.WriteLine($"The {player.Name} damaged {AIGladiator.Name}  for  {player.Strenght + playerDice}\n");
                AIGladiator.HP -= player.Strenght + playerDice;
                Console.WriteLine($"{AIGladiator.Name} remaining health is {AIGladiator.HP}");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
           }
            else if ((player.Strenght + playerDice) < (AIGladiator.Strenght + AIDice))
            {
                Console.WriteLine($" The {AIGladiator.Name} damaged {player.Name} for {AIGladiator.Strenght + AIDice}\n");
                player.HP -= AIGladiator.Strenght + AIDice;
                Console.WriteLine($"{player.Name} remaining health is {player.HP}");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Wierdly enough, both missed.");
                Console.WriteLine("----------------------------------------------------------------------------------------------");
            }


        }

         

    static int DiceRoll()
        {
            int d = random.Next(1, 6);

            return d;
        }
    }
}
