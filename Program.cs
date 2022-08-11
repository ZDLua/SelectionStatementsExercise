using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
          

            // create a function that asks the user to guess
            static void AskUserToGuess()
             
            {
            var r = new Random();
            var favNumber = r.Next(1,1000);

            Console.WriteLine("Guess my favorite number between 1 and 1000");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == favNumber)
            {
                Console.WriteLine("You guessed my favorite number!");
            }
            else if (guess > favNumber)
            {
                Console.WriteLine("Your guess is too high");
                AskUserToGuess();
                
            }
            else
            {
                Console.WriteLine("Your guess is too low");
                AskUserToGuess();
            }
            
           
        }
        AskUserToGuess();
        }
    }
}

