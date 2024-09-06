public class StandartCalculator
{
	//[Flags]

	public void AlgorithmStandartCalculator()
	{
		bool	IsExit = true,
				IsHaveSpecialSign = false; //if we have * or /

		int		countOfSteps = 1;

		float	result = .0f,
				bufer = 1;


        string	yesOrNo = null,
				mathProblem = null,
				strBufer = null;

        RecordingAndOutputHistory recordingAndOutputHistory = new RecordingAndOutputHistory();

        List<string>	arrayOfSignElements			= new List<string>();
		List<float>		arrayOfNumberElements		= new List<float>();
		List<string>	newArrayOfSignElements		= new List<string>();
		List<float>		newArrayOfNumberElements	= new List<float>();
			
        Console.Write(countOfSteps + " step)\n");
		mathProblem = Console.ReadLine();
        recordingAndOutputHistory.RecordingHistoryOfStandartCalculator(mathProblem);

		//At this loop u must do try...catch construction.
        foreach (string element in mathProblem.Split(' '))
		{
			Console.WriteLine(element);
            //if ((element.IndexOf % 2) != 0) // here you need to do a parity check index
            //{
            if (element == "+" || element == "-" || element == "*" || element == "/")
			{
				arrayOfSignElements.Add(element);
				if (IsHaveSpecialSign == false && (element == "*" || element == "/"))
				{
					IsHaveSpecialSign = true;
				}
			}
			//}
            else
            {
				if (element.IndexOf("sqrt") == 0)
				{
                    strBufer = element.Substring(4);

                    for (float i = 1; i < float.Parse(strBufer) + 1; i++)
					{
						if ((i * i) <= float.Parse(strBufer))
						{
                            if ((i * i) == float.Parse(strBufer))
							{
                                arrayOfNumberElements.Add(i);
                                break;
							}
                        }
						else
						{
							Console.Clear();
							Console.WriteLine("The number has no root!");
							Console.ReadKey();
							return;
						}
					}
                    continue;
                }

				//Lazy ass! Rewrite this.
				if (element.LastIndexOf("!") > 0)
				{
                    strBufer = element.Substring(0, element.Length - 1);

                    bufer = 1;

					for (float i = 1; i < float.Parse(strBufer) + 1; i++)
					{
						bufer = bufer * i;
					}

					arrayOfNumberElements.Add(bufer);
					continue;
				}

				try
				{
					arrayOfNumberElements.Add(float.Parse(element));
				}
				catch
				{
                    Console.Clear();
                    Console.WriteLine("Uncorrect x value! Try again.");
                    Console.ReadKey();
					return;
                }
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
										return;
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
										return;
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
									return;
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

        //Exit from algorithm: yes/no
        //Inccorrect sign
        //Add round for result value!(4.2 - 6.4 = -2.20001)
    }

	private float PlusAndMinosOperation(List<string> arrayOfSignElements, List<float> arrayOfNumberElements)
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
  

