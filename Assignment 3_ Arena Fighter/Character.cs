using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3__Arena_Fighter
{
    class Character
    {
        InfoGenerator genName = new InfoGenerator(DateTime.Now.Millisecond);
        Gender gender = Gender.Any;
        public Random dice = new Random();

        public string Name { get; set; }
        public int Strenght { get; set; }
        public int HP { get; set; }
        public int Victories { get; set; }

        public Character ()
        {
            this.Name = genName.NextFirstName(gender);
            HP = dice.Next(90, 110);
            Strenght = dice.Next(7, 12);
        }
        public Character(string Name)
        {
            this.Name = Name;
            HP = dice.Next (90, 110);
            Strenght = dice.Next(8,13);
            Victories = 0;
        }

        public void Status()
        {
            Console.WriteLine($"Name: {Name}\nHP: {HP}\nStr: {Strenght}\n");
        }
    }
}


