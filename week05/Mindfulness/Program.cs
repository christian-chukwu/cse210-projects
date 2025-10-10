// Exceeding Requirement: Keeps track of how many activities the user has completed in the session
// This goes beyond the core requirement by providing session progress feedback.

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int totalActivitiesCompleted = 0; // <-- added to track activities
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                Thread.Sleep(2000);
            }

            // Exceeding Requirement: Display session progress after each activity
            if (totalActivitiesCompleted > 0)
            {
                Console.WriteLine($"\nYou have completed {totalActivitiesCompleted} activities so far.");
                Thread.Sleep(2000);
            }
        }
    }
}



