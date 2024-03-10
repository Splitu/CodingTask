using System;
using System.Collections.Generic;

    class LotterySimulator
    {
        static List<int[]> drawHistory = new List<int[]>();
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lottery Simulator!");
            Console.WriteLine("----------------");
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Run");
            Console.WriteLine("2. History");
            Console.WriteLine("3. Exit");
            Console.WriteLine("----------------");


            while (true)
            {
                Console.Write("Choose action: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        RunLottery();
                        break;
                    case "2":
                        ShowHistory();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }

        static void RunLottery()
        {
            int[] draw = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, 50);
                } while (Array.IndexOf(draw, randomNumber) != -1);

                draw[i] = randomNumber;
            }

            Array.Sort(draw);

            Console.WriteLine("Lottery Result: " + string.Join(", ", draw));

            drawHistory.Add(draw);
        }

        static void ShowHistory()
        {
            Console.WriteLine("Previous Lottery Results:");
            foreach (var draw in drawHistory)
            {
                Console.WriteLine(string.Join(", ", draw));
            }
        }
    }