using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractClass
{
    public class D100Roll : DiceRoll
    {
        public override void RollDice(int num)
        {
            var results = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                results.Add(rnd.Next(1, 101));
            }

            Console.WriteLine("Your d100 roll(s):");

            foreach (var item in results)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
