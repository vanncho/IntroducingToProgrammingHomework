using System;

//A program that calculate my age after 10 years

class AgeAfter10Years
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Enter your current age:");
        a = Convert.ToInt32(Console.ReadLine());
        b = 10;
        c = a + b;
        Console.WriteLine("Your age after ten years will be: {0}", c);
        Console.ReadLine();
    }
}
