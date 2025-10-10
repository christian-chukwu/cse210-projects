using System;
using System.Threading;

public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing";
    _description = "This activity will help you relax by guiding you through slow breathing in and out.";
  }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
      Console.WriteLine("Breathe in...");
      Thread.Sleep(4000);
      Console.WriteLine("Now breathe out...");
      Thread.Sleep(4000);
    }

    DisplayEndingMessage();
  }
}