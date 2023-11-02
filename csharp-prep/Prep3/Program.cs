using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string stringNumber = Console.ReadLine();
        int secretNumber = int.Parse(stringNumber);

        while (true){
            Console.WriteLine("What is your guess?");
            string stringGuess = Console.ReadLine();
            int intGuess = int.Parse(stringGuess);

            if(intGuess > secretNumber){
                Console.WriteLine("You guessed too high");
            }
            else if (intGuess < secretNumber){
                Console.WriteLine("You guessed too low");
            }
            else {
                Console.WriteLine($"You guessed it! The secret number is {secretNumber}");
                break;
            }

        }
    }
}