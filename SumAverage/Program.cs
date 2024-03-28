using System;

namespace SumAverage
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int counter;
            List<double> list = new List<double>();

            Console.WriteLine("Welcome to Sum and Average Program!");
            Console.WriteLine("Number of inserts:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NOTE: 3 to 10 inserts.");
            Console.ForegroundColor = ConsoleColor.White;

            counter = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Now the " + counter + " numbers separed by an enter:");

            for (int i = 0; i < counter; i++) 
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.Write("Sum of the values: ");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(list.Sum());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Average of the values: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(list.Average());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}