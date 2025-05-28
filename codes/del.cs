using System;

// Define a delegate with a signature matching the methods it can reference
public delegate void MyDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the delegate and associate it with a method
        MyDelegate delegateInstance = new MyDelegate(PrintMessage);

        // Call the delegate
        delegateInstance("Hello, world!");
    }

    // Define a method that matches the delegate's signature
    static void PrintMessage(string message)
    {
        Console.WriteLine("Message received: " + message);
    }
}
