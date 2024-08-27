using System;

namespace MathStanadrtCalculator
{
	public class StandartCalculator
	{
		//[Flags]

		public static void AlgorithmStandartCalculator()
		{
			bool	IsExit = true,
					IsHaveResult = true,
					IsHaveSpecialSign = false; //if we have * or /

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
			List<string>	newArrayOfSignElements	= new List<string>();
			List<float>		newArrayOfNumberElements	= new List<float>();
			
            Console.Write(countOfSteps + " step)\n");
            mathProblem = Console.ReadLine();           //And i can remember string

            foreach (string element in mathProblem.Split(' '))
			{
                if (element == "+" || element == "-" || element == "*" || element == "/")
                {
					arrayOfSignElements.Add(element);
					//---> HERE <---//
                }
                else
                {
					//if (element.IndexOf("sqrt") == 0)
					//{
						//Console.WriteLine(strBufer);
						//Console.ReadKey();
					//}

					//Lazy ass! Rewrite this.
					if (element.LastIndexOf("!") > 0)
					{
						string strBufer = element;
                         strBufer = element.Substring(0, element.Length - 1);

                        float bufer = 1;

						for (float i = 1; i < float.Parse(strBufer) + 1; i++)
						{
							bufer = bufer * i;
						}

						arrayOfNumberElements.Add(bufer);
						continue;
					}

					arrayOfNumberElements.Add(float.Parse(element));//if i want do the sqrt or factorial, then float.parse will do after this string
                }
            }

			foreach (string element in arrayOfSignElements)
			{
				if (element == "*" || element == "/")//maybe move this condition in up (---> HERE <---), only without break//
				{
                    IsHaveSpecialSign = true;
					break;
                }
			}

			if (IsHaveSpecialSign)
			{
				for (int i = 0; i < arrayOfSignElements.Count; i++)
				{
					if (arrayOfSignElements[i] == "*" || arrayOfSignElements[i] == "/")
					{
						if (i != 0)
						{
							if (arrayOfSignElements[i - 1] == "*" || arrayOfSignElements[i - 1] == "/")
							{
                                switch (arrayOfSignElements[i])
                                {
                                    case "*":
                                        newArrayOfNumberElements[newArrayOfNumberElements.Count - 1] = newArrayOfNumberElements[newArrayOfNumberElements.Count - 1] * arrayOfNumberElements[i + 1];
                                        break;
                                    case "/":
                                        if (arrayOfNumberElements[i + 1] != .0f)
                                        {
                                            newArrayOfNumberElements[newArrayOfNumberElements.Count - 1] = newArrayOfNumberElements[newArrayOfNumberElements.Count - 1] / arrayOfNumberElements[i + 1];
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You can't divide by zero!");
                                            Console.ReadKey();
                                            //Come up with the end for divide by zero
                                        }
                                        break;
                                }
                            }
							else
							{
                                switch (arrayOfSignElements[i])
                                {
                                    case "*":
                                        newArrayOfNumberElements.Add(arrayOfNumberElements[i] * arrayOfNumberElements[i + 1]);
                                        break;
                                    case "/":
                                        if (arrayOfNumberElements[i + 1] != .0f)
                                        {
                                            newArrayOfNumberElements.Add(arrayOfNumberElements[i] / arrayOfNumberElements[i + 1]);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You can't divide by zero!");
                                            Console.ReadKey();
                                            //Come up with the end for divide by zero
                                        }
                                        break;
                                }
                            }
						}
						else
						{
							switch (arrayOfSignElements[i])
							{
								case "*":
									newArrayOfNumberElements.Add(arrayOfNumberElements[i] * arrayOfNumberElements[i + 1]);
									break;
								case "/":
									if (arrayOfNumberElements[i + 1] != .0f)
									{
										newArrayOfNumberElements.Add(arrayOfNumberElements[i] / arrayOfNumberElements[i + 1]);
									}
									else
									{
										Console.Clear();
										Console.WriteLine("You can't divide by zero!");
										Console.ReadKey();
										//Come up with the end for divide by zero
									}
									break;
							}
						}
                    }
                    else
					{
						newArrayOfSignElements.Add(arrayOfSignElements[i]);

						if (i != 0)
						{
							if (arrayOfSignElements[i - 1] != "*" && arrayOfSignElements[i - 1] != "/")
							{
								newArrayOfNumberElements.Add(arrayOfNumberElements[i]);
							}
						}
						else
						{
                            newArrayOfNumberElements.Add(arrayOfNumberElements[i]);
                        }
                    }
				}

				if (arrayOfSignElements[arrayOfSignElements.Count - 1] != "*" && arrayOfSignElements[arrayOfSignElements.Count - 1] != "/")
				{
					newArrayOfNumberElements.Add(arrayOfNumberElements[arrayOfNumberElements.Count - 1]);//add last element
				}
				result = PlusAndMinosOperation(newArrayOfSignElements, newArrayOfNumberElements);
            }
			else
			{
				result = PlusAndMinosOperation(arrayOfSignElements, arrayOfNumberElements);
            }

			Console.WriteLine("Result: " + result);
			Console.ReadKey();
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

			for (int i = 0; i < arrayOfSignElements.Count; i++)
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

