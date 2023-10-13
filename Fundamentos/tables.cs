using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Inserta el número: ");
        var number = Console.ReadLine();
        for (int index = 0; index < 11; index++)
        {
            int numint = Convert.ToInt32(number);
            var operation = (numint * index);
            Console.WriteLine($"{number} x {index} = {operation}");
        }

        Console.ReadKey();
    }
}