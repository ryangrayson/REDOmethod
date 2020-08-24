using System;

namespace REDOmethod
{
    class Program
    {
        static void Main(string[] args)
        {

        //---------------------Exercise 1-------------------
            //What's your name? Ryan
            //What's your favorite color? Black
            //What's your favorite animal? Honeybee
            //What's a band you are listening to right now? Kowloon Walled City

            Console.WriteLine("Hello, human. Can I have your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"{userName}? Humans call eachother such strange things\n" +
                $"What's your favorite color ..{userName}");

            var color = Console.ReadLine();
            Console.WriteLine($"{color} is a great color. That says a lot about you\n" +
                $"Do you have a favorite animal?");

            var animal = Console.ReadLine();
            Console.WriteLine($"{animal}... \nI'll have to ask you more about this creature once I am a smarter program\n" +
                $"Is there a band that you are currently listening to that you like a lot?");

            var band = Console.ReadLine();
            Console.WriteLine($"Cool, I'll have to check {band} out!");



        }
    }
}
