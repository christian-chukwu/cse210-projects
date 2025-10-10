// Exceeding Requirement: Displays a random motivational message at the end of each activity
// This goes beyond the core requirement of just ending the activity.

using System;
using System.Threading;

public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Starting {_name} Activity");
    Console.WriteLine(_description);
    Console.Write("Set duration in seconds: ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Get ready...");
    Thread.Sleep(2000);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine($"Well done! You completed the {_name} Activity for {_duration} seconds.");

    // Exceeding Requirement: Random encouragement message
    string[] messages = {
            "Great job! Keep up the good work!",
            "You’re making progress, stay consistent!",
            "That was awesome, keep going!",
            "Nice effort! Remember, little steps matter.",
            "Fantastic! You’re building a great habit."
        };

    Random rand = new Random();
    Console.WriteLine(messages[rand.Next(messages.Length)]);

    Thread.Sleep(2000);
  }
}