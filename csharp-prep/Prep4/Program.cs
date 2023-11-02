using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool repeat = true;
        while (repeat)
        {
            Console.Write("Enter a number (0 to quit)");
            string stringNum = Console.ReadLine();
            int newNumber = int.Parse(stringNum);

            if (newNumber == 0)
            {
                repeat = false;
            }
            else
            {
                numbers.Add(newNumber);
            }

        }
        int total = 0;
        foreach (int num in numbers)
        {
            total = total + num;
        }
        Console.WriteLine($"The sum of the list is: {total}");

        float avg = ((float)total) / numbers.Count;
        Console.WriteLine($"The average: {avg}");

        int maxNum = numbers.Max();
        Console.WriteLine($"The max number in th list is {maxNum}");
    }
}