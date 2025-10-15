using System;

class Program
{
    static void Main(string[] args)
    {

        // ****************************************************
        // Eternal Quest Program
        // Exceeding Requirements:
        // 1. Added a "Level Up" system: Player levels up every 1000 points.
        // 2. Added negative goals: You can create goals that subtract points for bad habits.
        // 3. Added motivational messages: After recording an event, the program prints
        //    a random encouraging message to keep the player inspired.
        // ****************************************************

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Track your goals, earn points, and stay motivated on your Eternal Quest.\n");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}