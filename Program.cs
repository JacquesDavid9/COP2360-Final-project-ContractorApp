// Member 1: Project Manager (Workflow & Main Execution Loop). Builds the main console loop that requests input to spawn new. Subcontractor records and stores them in a shared list.
// Also handles invalid menu input so the program never crashes.
 
using System;
using System.Collections.Generic;
 
namespace ContractorApp
{
    class Program
    {
        // Shared list of subcontractors used across the whole program. Member 4 will build out the real collection/parsing logic. This is the shared structure everyone plugs into.
        static List<Subcontractor> subcontractors = new List<Subcontractor>();
 
        static void Main()
        {
            bool running = true;
 
            while (running)
            {
                PrintMenu();
 
                string input = Console.ReadLine();
 
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from the menu.\n");
                    continue;
                }
 
                switch (choice)
                {
                    case 1:
                        AddSubcontractor();
                        break;
 
                    case 2:
                        DisplaySubcontractors();
                        break;
 
                    case 3:
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
 
                    default:
                        Console.WriteLine("That option doesn't exist. Please choose a valid number.\n");
                        break;
                }
            }
        }
 
        static void PrintMenu()
        {
            Console.WriteLine("========= Contractor Management System =========");
            Console.WriteLine("1. Add a new subcontractor");
            Console.WriteLine("2. Display all subcontractors");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
        }
 
        // Requests input to create a new Subcontractor record. Member 5 will later wrap this input in stronger validation and try catch guards. This is the basic working version.
        static void AddSubcontractor()
        {
            Console.Write("Enter contractor name: ");
            string name = Console.ReadLine();
 
            Console.Write("Enter contractor number: ");
            string number = Console.ReadLine();
 
            Console.Write("Enter contractor start date: ");
            string startDate = Console.ReadLine();
 
            Console.Write("Enter shift (1 = Day, 2 = Night): ");
            int shift = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter hourly pay rate: ");
            double payRate = Convert.ToDouble(Console.ReadLine());
 
            Subcontractor sub = new Subcontractor(name, number, startDate, shift, payRate);
            subcontractors.Add(sub);
 
            Console.WriteLine($"Subcontractor {name} added.\n");
        }
 
        static void DisplaySubcontractors()
        {
            Console.WriteLine("\n-- Subcontractor List --");
            foreach (Subcontractor s in subcontractors)
            {
                Console.WriteLine($"{s.ContractorName} | #{s.ContractorNumber} | Shift: {s.Shift} | Pay: {s.HourlyPayRate}");
            }
            Console.WriteLine();
        }
    }
}
