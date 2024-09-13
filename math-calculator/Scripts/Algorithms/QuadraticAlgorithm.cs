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

            numbers = BubbleSort(numbers);
            ArrayOperations.OutPutArray(numbers, "Bubble sort");
            Console.ReadKey();
        }

        public static List<int> BubbleSort(List<int> numbers)
		{
            int buferValue = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        buferValue = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = buferValue;
                    }
                }
            }

            return numbers;
        }
	}
}

