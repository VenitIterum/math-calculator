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
					IsHaveResult = true,
					IsHaveSpecialSignl = true; //if we have * or /

			int		countOfSteps = 1;

			float	xValue = .0f,
					yValue = .0f,
					result = .0f,
					tempResult = 1.0f;

			string	sign = null,
					yesOrNo = null,
					mathProblem = null;

			List<string>	arrayOfSignElements		= new List<string>();
			List<float>		arrayOfNumberElements	= new List<float>();
			List<string>	arrayOfSignElements2	= new List<string>();
			List<float>		arrayOfNumberElements2	= new List<float>();

            Console.Write(countOfSteps + " step)\n");
            mathProblem = Console.ReadLine();           //And i can remember string

            foreach (string element in mathProblem.Split(' '))
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

			foreach (string element in arrayOfSignElements)
			{
				if (element == "*" || element == "/")
				{
                    IsHaveSpecialSignl = true;
					break;
                }

			}

			if (IsHaveSpecialSignl)
			{
				for (int i = 0; i < arrayOfSignElements.Count; i++)
				{
					if (arrayOfSignElements[i] == "*" || arrayOfSignElements[i] == "/")
					{
						if (i != 0)
						{
							if (arrayOfSignElements[i - 1] != "*" || arrayOfSignElements[i - 1] != "/")
							{
								tempResult = arrayOfNumberElements[i] * arrayOfNumberElements[i + 1];
							}
						}
						else
						{
							if (arrayOfSignElements[i] == "*")
							{
								tempResult = arrayOfNumberElements[i] * arrayOfNumberElements[i + 1];
							}
							else if (arrayOfSignElements[i] == "/")
							{
								if (arrayOfNumberElements[i + 1] != .0f)
								{
									tempResult = arrayOfNumberElements[i] / arrayOfNumberElements[i + 1];
								}
								else
								{
									Console.Clear();
									Console.WriteLine("You can't divide by zero!");
									Console.ReadKey();
									break;
								}
							}
						}
					}
					//else if (arrayOfSignElements[i] == "+" || arrayOfSignElements[i] == "-")
					//{
						//Лять, диллема! Наверное лучше сразу проходиться по списку и проверять, а есть ли там знаки умножить и разделить. Ибо если есть, то мы идём по сложному алгоритму, а если нет?
						//Нахрена нам идти по сложному, есил нету у нас в строке знаков умнодить и разделить. Значит можно замутить отдельный метод, где будет выполняться просто алгоритм

						//arrayOfNumberElements2.Add(arrayOfNumberElements[i]);
						//summa and minos
					//}
					else
					{
						Console.Clear();
						Console.WriteLine();
						Console.ReadKey();
						break;
					}
				}
			}
			else
			{
				result = PlusAndMinosOperation(arrayOfSignElements, arrayOfNumberElements);
            }

			Console.WriteLine("Result: " + result);
			Console.ReadKey();
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

		public static float PlusAndMinosOperation(List<string> arrayOfSignElements, List<float> arrayOfNumberElements)
		{
			float result = arrayOfNumberElements[0];

			for (int i = 0; i< arrayOfSignElements.Count; i++)
			{
				switch (arrayOfSignElements[i])
				{
					case "+":
						result = result + arrayOfNumberElements[i + 1];
                        break;
					case "-":
						result = result - arrayOfNumberElements[i + 1];
						break;
					default:
						break;
				}
			}

			return result;
		}
    }
}

