using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity()
  {
    _name = "Reflection";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    _prompts = new List<string>
        {
            "Think of a time when you did something really difficult.",
            "Recall a moment when you helped someone in need.",
            "Think about a time when you pushed through fear to achieve something."
        };
    _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How can you apply this strength to future challenges?"
        };
  }

  public void Run()
  {
    DisplayStartingMessage();

    Random rand = new Random();
    string prompt = _prompts[rand.Next(_prompts.Count)];
    Console.WriteLine($"\nPrompt: {prompt}");
    Console.WriteLine("Reflect on this prompt...");

    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      string question = _questions[rand.Next(_questions.Count)];
      Console.WriteLine(question);
      Thread.Sleep(5000);
    }

    DisplayEndingMessage();
  }
}