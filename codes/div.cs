using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = 10 / number;

            Console.WriteLine("Result of division: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
