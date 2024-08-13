using System;

namespace MathCalculator
{
    internal class Program
    {
        private static void Main()
        {
            var text = "";

            text = Console.ReadLine();
            OutPut(text);
        }

        private static void OutPut(string textForOutPut)
        {
            //Test pull request!
            Console.WriteLine("U write: " + textForOutPut);
            Console.ReadKey();
        }
    }
}

