using System;
namespace Algorithms
{
	public class CubicAlgorithm
	{
		public void ThreeDimensionalMatrixOutPut()
		{
			int[,,] matrix = new int[3,3,3];

			Random rand = new Random();

            for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"\nPart of matrix 3x3x3 #{i + 1}:");
				for (int j = 0; j < 3; j++)
				{
					for (int k = 0; k < 3; k++)
					{
						matrix[i, j, k] = rand.Next(0, 100);
                        Console.Write($"{matrix[i, j, k]}\t");
					}
					Console.Write("\n");
				}
			}
			Console.ReadKey();
		}
	}
}

