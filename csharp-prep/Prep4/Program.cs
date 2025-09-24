using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int userNum = -1;
        List<int> numbers = new List<int>();

        while (userNum != 0)
        {
            Console.Write("Enter a number: ");
            string enterNum = Console.ReadLine();
            userNum = int.Parse(enterNum);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // Number of numbers in the list
        Console.WriteLine($"Numbers in the list: {numbers.Count}");

        // Add the items of the list together to make the sum of the list.
        int Sum = numbers.Sum();
        Console.WriteLine($"The sum is: {Sum}");
    }
}