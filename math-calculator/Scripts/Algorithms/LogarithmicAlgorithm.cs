using System;
using System.Security.Cryptography;

namespace Algorithms
{
	public class LogarithmicAlgorithm
	{
		public void StartLogarithmicAlgorithm()
		{
            int key     = 0;

            char arrayYesOrNo = ' ';

            bool IsGenerateArray = false;

            string strNumbers = null;

            List<int> numbers = new List<int>();

            Random random = new Random();

            Console.WriteLine("Generate an array for you? (y/n)");
            while (arrayYesOrNo != 'y' && arrayYesOrNo != 'n')
            {
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
            }

            if (IsGenerateArray)
            {
                numbers = ArrayOperations.GenerateArray();
                ArrayOperations.OutPutArray(numbers, "Generated array");
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

            ArrayOperations.LinearSearch(key, numbers, "before sorting");

            numbers = ArrayOperations.BubbleSort(numbers);
            ArrayOperations.OutPutArray(numbers, "Bubble sort");

            ArrayOperations.LinearSearch(key, numbers, "after sorting");

            ArrayOperations.BinarySearch(key, numbers);
            Console.ReadKey();
        }
    }
}

