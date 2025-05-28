using System;

public class funcexer3
{
    // Define a public static method 'Sum' that takes two integer parameters and returns their sum
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    // Main method, the entry point of the program
    public static void Main()
    {
        // Print a description of the program
        Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
        
        Console.Write("Enter a number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));
    }
}
