using System;

namespace ImplicitExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string myString = "15";
                string mySecondString = "13";
          
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int result = num1 + num2;

            Console.WriteLine(result);
            Console.Read();
        }
            
       
    }
}
