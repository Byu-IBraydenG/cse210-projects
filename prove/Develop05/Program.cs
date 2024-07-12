using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            bool exit = false;

            goalManager.LoadGoals();

            while (!exit)
            {
                Console.WriteLine("\nEternal Quest Menu:");
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. Create Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            goalManager.DisplayPlayerInfo();
                            break;
                        case 2:
                            goalManager.CreateGoal();
                            break;
                        case 3:
                            goalManager.RecordEvent();
                            break;
                        case 4:
                            goalManager.SaveGoals();
                            break;
                        case 5:
                            goalManager.LoadGoals();
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Thank you for using Eternal Quest!");
        }
    }
}