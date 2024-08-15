using System;

namespace math_calculator
{
	public class StandartCalculator
	{
		//private enum Sign
		//{
		//	Plus,
		//	Minous,
		//	Multiply,
		//	Devide
		//}

		//private static float StartCalculations()
		//{
		//	float result = 0.0f;

		//	return result;
		//}

        public static void AlgorithmStandartCalculator()
		{
			bool	IsExit = true,
					IsHaveResult = true;

			int		countOfSteps = 1;

			float	xValue = 0.0f,
					yValue = 0.0f,
					result = 0.0f;

			string	sign = null,
					yesOrNo = null,
					mathProblem = null;

			List<string>	arrayOfSignElements		= new List<string>();
			List<float>		arrayOfNumberElements	= new List<float>();

            Console.Write(countOfSteps + " step)\n");
            mathProblem = Console.ReadLine();

			foreach(string element in mathProblem.Split(' '))
			{
                if (element == "+" || element == "-" || element == "*" || element == "/")
                {
					arrayOfSignElements.Add(element);
                }
                else
                {
					arrayOfNumberElements.Add(float.Parse(element));//if i want do the sqrt or factorial, then float.parse will do after this string
                }
            }

			//result = StartCalculations();
			return;

            //Old version
            Console.Write(countOfSteps + " step)\nx = ");
			try
			{
				xValue = float.Parse(Console.ReadLine());
			}
			catch
			{
				Console.Clear();
				Console.WriteLine("Uncorrect x value! Try again.");
				Console.ReadKey();
				return;
			}

			while (IsExit)
			{
				yesOrNo = null;

                Console.Write("Sign: ");
				sign = Console.ReadLine();

				Console.Write("y = ");
				try
				{
					yValue = float.Parse(Console.ReadLine());
				}
				catch
				{
					Console.Clear();
					Console.WriteLine("Uncorrect y value! Try again.");
					Console.ReadKey();
					return;
				}

				//Add round for result value! (4.2 - 6.4 = -2.20001)
				switch (sign)
				{
					case "+":
						result = xValue + yValue;
						break;
					case "-":
						result = xValue - yValue;
						break;
					case "*":
						result = xValue * yValue;
						break;
					case "/":
						if (yValue == 0.0f)
						{
							IsHaveResult = false;
							Console.Clear();
							Console.WriteLine("You can't divide by zero! Try again.");
						}
						else
						{
							result = xValue / yValue;
						}
						break;
					default:
						IsHaveResult = false;
						Console.Clear();
						Console.WriteLine("Please, enter correct sign.");
						break;
				}

				if (IsHaveResult) Console.WriteLine("Result " + xValue + " " + sign + " " + yValue + " = " + result);

				Console.WriteLine("Continue with the given value or exit? (y/n)");
				while (yesOrNo != "y" && yesOrNo != "n")
				{
					yesOrNo = Console.ReadLine();

					if (yesOrNo == "y")
					{
						IsExit = true;
						xValue = result;
						//Console.Clear();
						countOfSteps++;
                        Console.WriteLine("\n" + countOfSteps + " step)\nx = " + xValue);
					}
					else if (yesOrNo == "n")
					{
						IsExit = false;
						Console.Clear();
					}
					else
					{
						Console.WriteLine("\nEnter y or n.");
					}
				}
			}
        }
    }
}

