using System;

//A program to print my Name and Last Name in C#
class PrintMyName
{
    static void Main()
    {
        System.Console.Write("Enter your first name:");
        string firstName = System.Console.ReadLine();
        System.Console.Write("Enter your last name:");
        string lastName = System.Console.ReadLine();
        System.Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        System.Console.ReadLine();
    }
}
