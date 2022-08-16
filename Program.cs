using System;

namespace CSharp_Youtube_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiplyer"; 
            Console.ForegroundColor = ConsoleColor.Green;

            //looks

            int num01;
            int num02;

            Console.Write("First Number: ");

            num01 = Convert.ToInt32(Console.ReadLine() );

            //recieve first number

            Console.Write("Second Number: ");

            num02 = Convert.ToInt32(Console.ReadLine() );

            //recieve second number

            int result = num01 * num02;

            Console.Write("Result=" + result);

            Console.Write("\n\nPress Any Key to Close");
            
            Console.ReadKey();
            //closes on key press
        }
    }
}