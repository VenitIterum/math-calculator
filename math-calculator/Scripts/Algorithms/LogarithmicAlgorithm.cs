using System;
using System.Security.Cryptography;

namespace Algorithms
{
	public class LogarithmicAlgorithm
	{
		public void BinarySearch()
		{
            int key     = 0;
            int low     = 0;
            int mid     = 0;
            int high    = 0;
            int numberOfIterations = 0;

            char arrayYesOrNo = ' ';

            bool IsKeyFound = false;
            bool IsGenerateArray = false;

            string strNumbers = null;

            List<int> numbers = new List<int>();

            Random random = new Random();

            Console.WriteLine("Generate an array for you? (y/n)");
            try
            {
                arrayYesOrNo = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Uncorrected value for menu! Please, enter y/n!");
                Console.ReadKey();
                return;
            }

            switch (arrayYesOrNo)
            {
                case 'y':
                    IsGenerateArray = true;
                    break;
                case 'n':
                    IsGenerateArray = false;
                    break;
                default:
                    Console.WriteLine("Enter uncorrected value! Please, enter y/n!");
                    break;
            }

            if (IsGenerateArray)
            {
                for (int i = 0; i < 100; i++)
                {
                    numbers.Add(random.Next(1, 100));
                }

                OutPutArray(numbers, "Generated array");
            }
            else
            {
                Console.WriteLine("Enter array of integer numbers:");
                strNumbers = Console.ReadLine();

                foreach (string element in strNumbers.Split(" "))
                {
                    numbers.Add(Convert.ToInt32(element));
                }
            }

            Console.WriteLine("\nEnter any key:");
            try
            {
                key = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Uncorrected value for key!");
                Console.ReadKey();
                return;
            }

            LinearSearch(key, numbers, "before sorting");

            numbers = SortingArray(numbers);

            LinearSearch(key, numbers, "after sorting");

            low = 0;
            high = numbers.Count - 1;

            while (low <= high)
            {
                numberOfIterations++;
                mid = low + (high - low) / 2;

                if (key < numbers[mid]) high = mid - 1;
                else if (key > numbers[mid]) low = mid + 1;
                else
                {
                    IsKeyFound = true;
                    break;
                }
            }

            Console.WriteLine("\nBinary search:");
            if (IsKeyFound)
            {
                Console.WriteLine($"Key = {mid + 1} (count of iterations = {numberOfIterations})");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Key not found! (count of iterations = {numberOfIterations})");
                Console.ReadKey();
            }
        }

        private List<int> LinearSearch(int key, List<int> numbers, string textAfterBegore)
        {
            int numberOfIterations = 0;

            bool IsKeyFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                numberOfIterations++;

                if (key == numbers[i])
                {
                    IsKeyFound = true;
                    break;
                }
            }

            Console.WriteLine($"\nLinear search {textAfterBegore}:");
            if (IsKeyFound)
            {
                Console.WriteLine($"Key = {numberOfIterations} (count of iterations = {numberOfIterations})");
            }
            else
            {
                Console.WriteLine($"Key not found! (count of iterations = {numberOfIterations})");
            }

            return numbers;
        }

        private List<int> SortingArray(List<int> numbers)
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

            OutPutArray(numbers, "Sorting array:");
            return numbers;
        }

        private void OutPutArray(List<int> numbers, string text)
        {
            Console.WriteLine($"\n{text}:");
            foreach (int element in numbers)
            {
                Console.Write($"{element} ");
            }
            Console.Write($"\n");
        }
    }
}

