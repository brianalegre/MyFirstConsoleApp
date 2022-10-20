using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Hello World in Command Prompt
            Console.WriteLine("Hello World!");

            // Tell The User To Do Something
            Console.WriteLine("Type something for me to store");

            // Get User Input
            string userInput = Console.ReadLine();

            // Print User Input
            Console.WriteLine($"You typed: {userInput}");
            
        }
    }
}
