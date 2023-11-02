using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);

        string letter = "";

        if(intGrade >= 90) {
            letter = "A";
        }
        else if (intGrade >= 80){
            letter = "B";
        }
        else if (intGrade >= 70){
            letter = "C";
        }
        else if (intGrade >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter} in the class!");
        if(intGrade < 70){
            Console.WriteLine("Better luck next time!");
        }
        else {
            Console.WriteLine("You Passed!");
        }
    }
}