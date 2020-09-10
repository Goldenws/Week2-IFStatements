using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("What is your favourite animal?");
            UserInput = Console.ReadLine();

            if (UserInput == "cat")
            {
                Console.WriteLine("You are a HomeBird.");
            }
            else if (UserInput == "dog")
            {
                Console.WriteLine("you are a partygoer.");
            }
            else
            {
                Console.WriteLine($"You are a {UserInput} freind");
            }














        }      
                    
                    
              
        }
    }
