using System;

namespace Algorithms
{
	public class QuadraticAlgorithm
    {
        public void BubbleSort()
        {
            int lenghtArray = 0;
            List<int> numbers = new List<int>();

            Console.WriteLine("How long should your array be?");
            try
            {
                lenghtArray = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Uncorrected value for menu! Please, enter y/n!");
                Console.ReadKey();
                return;
            }

            numbers = ArrayOperations.GenerateArray(lenghtArray);
            ArrayOperations.OutPutArray(numbers, "Random array");

            numbers = ArrayOperations.BubbleSort(numbers);
            ArrayOperations.OutPutArray(numbers, "Bubble sort");
            Console.ReadKey();
        }
	}
}

