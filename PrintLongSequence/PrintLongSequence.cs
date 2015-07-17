using System;

//A program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, 8.
    class PrintLongSequence
    {
        static void Main()
        {
            for (int i=2; i < 1003; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i + " ");  
                }
                else
                {
                    System.Console.WriteLine(-i + " ");
                }
            }
        }
    }
