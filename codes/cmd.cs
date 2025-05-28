using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No command-line arguments provided.");
        }
        else
        {
            Console.WriteLine("Command-line arguments:");
            
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }
        }
    }
}
