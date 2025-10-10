// Exceeding Requirement: Displays the number of items the user listed at the end of the activity
// This goes beyond the core requirement of simply listing items without feedback

using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
  private int _count; // keeps track of the number of items listed
  private List<string> _prompts;

  public ListingActivity()
  {
    _name = "Listing";
    _description = "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.";
    _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
  }

  public void Run()
  {
    DisplayStartingMessage();

    Random rand = new Random();
    string prompt = _prompts[rand.Next(_prompts.Count)];
    Console.WriteLine($"\nPrompt: {prompt}");
    Console.WriteLine("Start listing items:");

    List<string> userList = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      string input = Console.ReadLine();
      if (!string.IsNullOrEmpty(input))
      {
        userList.Add(input);
      }
    }

    _count = userList.Count; // now _count is actually used
    Console.WriteLine($"\nYou listed {_count} items!");

    DisplayEndingMessage();
  }
}