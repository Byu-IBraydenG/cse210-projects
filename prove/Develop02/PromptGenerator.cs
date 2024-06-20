using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;

class PromptGenerator
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter your response:");
                Console.Write("> ");
                string response = Console.ReadLine();
                journal.AddEntry(response);
            }

            else if (choice == "2")
            {
                journal.DisplayEntries();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter filename to save");
                Console.Write("> ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }

            else if (choice == "4")
            {
                Console.WriteLine("Enter file name to load");
                Console.Write("> ");
                string loadFromFile = Console.ReadLine();
                journal.LoadFromFile(loadFromFile);
            }

            else if (choice == "5")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            
        }
    }
}