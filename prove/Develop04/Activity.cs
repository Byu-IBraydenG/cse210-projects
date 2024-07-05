using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        ShowCountDown(3); // Pause for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed this activity.");
        Console.WriteLine($"Activity completed: {_name}, Duration: {_duration} seconds.");
        ShowCountDown(3); // Pause for 3 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/\r");
            Thread.Sleep(100);
            Console.Write("-\r");
            Thread.Sleep(100);
            Console.Write("\\\r");
            Thread.Sleep(100);
            Console.Write("|\r");
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public abstract void Run();
}
