//For my "showing creativity" portion of the assignment, I decided to add music playing in the background. You have to add the NuGet Package called "NAudio" in order for it to work, so hopefully this works on more than just my set up. 

using System;
using NAudio.Wave;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        Console.Clear();

        using (var audioFile = new AudioFileReader("Bloom.mp3"))
        {
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (loop == true)
                {


                    Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listing Activity\n4. Quit\n\nSelect a choice from the menu: ");
                    string userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.Clear();
                        List<string> promptList = new List<string>();
                        List<string> animationCharacterList = new List<string>();

                        Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", promptList, 30, animationCharacterList);

                        breathing.BreathingActivity();
                        Console.Clear();
                    }

                    else if (userInput == "2")
                    {
                        Console.Clear();
                        List<string> promptList = new List<string> { "Think of a time when you did something really difficult.", "What is an experience you've had where you've felt stronger after the fact?", "What is something you've done in the last week that you're proud of?" };
                        List<string> animationCharacterList = new List<string>();
                        List<string> questionList = new List<string> { "How did you feel when it was complete?", "Would you go through this again knowing what you know now?", "What is some advice you would give to someone else going throug something similar?", "What is something you wish happened differently about this experience?", "Was there anyone in your life that helped you through this?", "What would you do differently if this happens again?" };

                        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you use it in other aspects of your life.", promptList, 30, animationCharacterList, questionList);

                        reflection.ReflectionActivity();
                        Console.Clear();
                    }

                    else if (userInput == "3")
                    {
                        Console.Clear();
                        List<string> promptList = new List<string>{"When have you felt the Holy Ghost this month?", "Who are people you are glad to know?", "What are things you are grateful for?", "What have you done to make someone else's day better this week?", "What are some accomplishments you have made this week?"};
                        List<string> animationCharacterList = new List<string>();

                        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", promptList, 30, animationCharacterList);

                        listing.ListingActivity();
                        Console.Clear();
                    }

                    else if (userInput == "4")
                    {
                        Console.WriteLine("\nSee you next time!");
                        loop = false;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nInvalid input. Hit your 'enter' key to continue back to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                outputDevice.Stop();
            }
        }
    }
}