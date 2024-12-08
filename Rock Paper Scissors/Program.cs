using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            Console.WriteLine("\r");
            Console.WriteLine("||======================||");
            Console.WriteLine("||Welcome to my minigame||");
            Console.WriteLine("||  ROCK PAPER SCISSORS ||");
            Console.WriteLine("||======================||");
            Console.WriteLine("\n");

            while (true)
            {
                int ComputerChoiceNumber = random.Next(Choices.Length);
                string ComputerChoice = Choices[ComputerChoiceNumber];

                Console.WriteLine("\r");
                Console.Write("\rEnter your choice: ");
                string UserChoice = Console.ReadLine().ToLower();




                if (Array.Exists(Choices, element => element == UserChoice))
                {
                    Console.WriteLine($"Computer choice: {ComputerChoice}");
                    if (ComputerChoice == UserChoice)
                    {
                        
                        Console.WriteLine("Its a TIE!");

                    }
                    else if ((UserChoice == "rock" && ComputerChoice == "scissors") ||
                        (UserChoice == "paper" && ComputerChoice == "rock") ||
                        (UserChoice == "scissors" && ComputerChoice == "paper"))
                    {
                        
                        Console.WriteLine("You win!");

                    }

                    else
                    {
                        Console.WriteLine("You lose!");

                    }
                }
                else
                {

                    Console.WriteLine("please chose an valid choice: rock paper or schissor: ");

                }
            }
        }
    }
}
