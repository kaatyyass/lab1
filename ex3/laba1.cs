using System;
using System.Threading.Channels;


class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a sequence of numbers: ");
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var selectedNumber = from number in numbers
                where number > 0
                select (number);
            Console.WriteLine(String.Join(' ', selectedNumber));
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
    }
}