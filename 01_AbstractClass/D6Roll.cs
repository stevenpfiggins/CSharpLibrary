using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01_AbstractClass
{
    public class D6Roll : DiceRoll
    {
        public override void RollDice(int num)
        {
            var results = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                results.Add(rnd.Next(1, 7));
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
