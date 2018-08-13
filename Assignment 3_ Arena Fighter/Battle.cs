using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3__Arena_Fighter
{
    class Battle
    {

        public Character AIGladiator;
        public Character Player;

        public void ToBattle (Character Player, Character AIGladiator)
        {
            this.Player = Player;
            this.AIGladiator = AIGladiator;

            do
            {
                Round round = new Round();
                round.Fight(Player, AIGladiator);

            } while (Player.HP > 0 && AIGladiator.HP > 0);

            //if (Player.HP <= 0)
            //{
            //    Console.WriteLine($"{AIGladiator.Name} won, you lost\n");
            //    Player.Status();
            //    Console.WriteLine($"The number of slain foes by your hand were {Player.Victories}");
            //    foreach (var item in history)
            //    {
            //        Console.WriteLine($"{item.player.Name} vs {item.AIGladiator.Name}");
            //    }
            //}
            //else if (AIGladiator.HP <= 0)
            //{
            //    Console.WriteLine($"Congaratiolations {Player.Name} you won the battle");
            //    Player.Victories++;
            //    Console.WriteLine($"The number of slain foes by your hand were {Player.Victories}´\n");
            //    Console.WriteLine(" what want to do, continue in the Blood Pit to win more Prestige (press y ) or do you want to retire with the prestige you have and leave the Blood Pit alive (Press x)");

            //}
        }
        
    }
}
