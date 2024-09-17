using System;
namespace Algorithms
{
	public class Linear_logarithmicAlgorithm
	{
		public void MergeSort()
		{
			int i = 0;
			int j = 0;

			List<int> arr1 = new List<int>();
			List<int> arr2 = new List<int>();
			List<int> arr3 = new List<int>();

            //Original Merge Sort algorithm already has sort.
            //The algorithm itself works through a recursive method by dividing arrays into small ones.
            //For now, I've decided to do this through bubble sorting.
            arr1 = ArrayOperations.BubbleSort(ArrayOperations.GenerateArray(40, 0, 5000));
			arr2 = ArrayOperations.BubbleSort(ArrayOperations.GenerateArray(50, 0, 7500));

			ArrayOperations.OutPutArray(arr1, "Array #1");
			ArrayOperations.OutPutArray(arr2, "Array #2");

			for (int k = 0; k < (arr1.Count + arr2.Count); k++)
			{
				if (i > (arr1.Count - 1))
				{
					arr3.Add(arr2[j]);
					j++;
				}
				else if (j > (arr2.Count - 1))
				{
					arr3.Add(arr1[i]);
					i++;
				}
				else if (arr1[i] < arr2[j])
				{
					arr3.Add(arr1[i]);
					i++;
				}
				else
				{
					arr3.Add(arr2[j]);
					j++;
				}
			}

			ArrayOperations.OutPutArray(arr3, "Array #3");
			Console.ReadKey();
		}
    }
}

