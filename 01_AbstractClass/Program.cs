using System;
using System.Collections.Generic;

namespace _01_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int numDice;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Dice Roller! Please choose a number:\n" +
                    "\t1. Roll d4\n" +
                    "\t2. Roll d6\n" +
                    "\t3. Roll d8\n" +
                    "\t4. Roll d10\n" +
                    "\t5. Roll d12\n" +
                    "\t6. Roll d20\n" +
                    "\t7. Roll d100\n" +
                    "\t8. Exit");

                var response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Console.Clear();
                        DiceRoll d4 = new D4Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d4.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        DiceRoll d6 = new D6Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d6.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        DiceRoll d8 = new D8Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d8.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        DiceRoll d10 = new D10Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d10.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        DiceRoll d12 = new D12Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d12.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        DiceRoll d20 = new D20Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d20.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        DiceRoll d100 = new D100Roll();
                        Console.WriteLine("How many dice would you like to roll?");
                        numDice = int.Parse(Console.ReadLine());
                        d100.RollDice(numDice);
                        Console.ReadLine();
                        break;
                    case "8":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{response} is not a valid input. Please try again.");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
