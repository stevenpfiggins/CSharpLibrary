using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractClass
{
    public class D12Roll : DiceRoll
    {
        public override void RollDice(int num)
        {
            var results = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                results.Add(rnd.Next(1, 13));
            }

            Console.WriteLine("Your d12 roll(s):");

            foreach (var item in results)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
