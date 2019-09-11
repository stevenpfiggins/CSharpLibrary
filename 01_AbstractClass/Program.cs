using System;
using System.Collections.Generic;

namespace _01_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DiceRoll> rolls = new List<DiceRoll>()
            {
                new D6Roll(),
                new D20Roll()
            };

            foreach (var roll in rolls)
            {
                Console.WriteLine("Your rolls are:");
                roll.RollDice(2);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
