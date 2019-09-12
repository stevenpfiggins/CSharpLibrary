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
                bool subMenuRunning = true;
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
                    case "1":;
                        Console.Clear();
                        DiceRoll d4 = new D4Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d4.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "2":
                        Console.Clear();
                        DiceRoll d6 = new D6Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d6.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "3":
                        Console.Clear();
                        DiceRoll d8 = new D8Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d8.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "4":
                        Console.Clear();
                        DiceRoll d10 = new D10Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d10.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "5":
                        Console.Clear();
                        DiceRoll d12 = new D12Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d12.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "6":
                        Console.Clear();
                        DiceRoll d20 = new D20Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d20.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "7":
                        Console.Clear();
                        DiceRoll d100 = new D100Roll();
                        while (subMenuRunning)
                        {
                            SubMenuIntro();
                            var success = int.TryParse(Console.ReadLine(), out numDice);
                            if (success)
                            {
                                d100.RollDice(numDice);
                                subMenuRunning = false;
                            }
                            else
                            {
                                NotANumberErrorHandling();
                            }

                        }
                        Console.ReadLine();
                        subMenuRunning = false;
                        break;
                    case "8":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{response} is not a valid input. Please try again.");
                        Console.Clear();
                        subMenuRunning = false;
                        break;
                }
            }
        }

        public static void NotANumberErrorHandling()
        {
            Console.WriteLine("That is not a valid input. Please try again");
            Console.ReadLine();
        }

        public static void SubMenuIntro()
        {
            Console.Clear();
            Console.WriteLine("How many dice would you like to roll?");
        }
    }
}
