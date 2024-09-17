using System;

namespace Algorithms
{
	public class LinearAlgorithm
    {
		public void Factorial()
        {
            int number = 0;
            int factoial = 1;

            Console.WriteLine("Enter a integr number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                factoial *= i;
            }

            Console.WriteLine($"{number}! = {factoial}");
            Console.ReadLine();
        }
    }
}

