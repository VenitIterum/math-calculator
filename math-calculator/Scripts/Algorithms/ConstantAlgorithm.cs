using System;

namespace Algorithms
{
	public class ConstantAlgorithm
    {
		public void StartConstantAlgorithm()
		{
			string strValue = null;

			Console.WriteLine("Enter any value:");
            strValue = Console.ReadLine();

			try
			{
				if (float.Parse(strValue) >= 0)
				{
					Console.WriteLine($"Result: {float.Parse(strValue)} >= 0");
				}
				else
				{
					Console.WriteLine($"Result: {float.Parse(strValue)} < 0");
				}
            }
			catch
			{
                Console.WriteLine($"Result: '{strValue}' is string type!");
            }
			Console.ReadKey();
        }
	}
}

