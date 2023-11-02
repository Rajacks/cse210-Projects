using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");

        static string GetName()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int GetFavNum()
        {
            Console.Write("Enter your favorite number: ");
            string stringFavNum = Console.ReadLine();
            int favNum = int.Parse(stringFavNum);
            return (favNum * favNum);
        }

        Console.WriteLine($"{GetName()}, the square of your favorite number is: {GetFavNum()}");

    }
}