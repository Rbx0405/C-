using System;

class Program
{
    static void Main(string[] args)
    {
        int intValue = 10;
        object boxedValue = intValue; 

        Console.WriteLine("Boxed value: " + boxedValue);
        int unboxedValue = (int)boxedValue; 

        Console.WriteLine("Unboxed value: " + unboxedValue);
        int[] intArray = { 1, 2, 3, 4, 5 };
        object boxedArray = intArray; 

        Console.WriteLine("Boxed array: " + boxedArray);

        
        int[] unboxedArray = (int[])boxedArray; 

        Console.Write("Unboxed array: ");
        foreach (int num in unboxedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
