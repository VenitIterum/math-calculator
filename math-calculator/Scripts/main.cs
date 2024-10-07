using System;
using Algorithms;
using DataStructure;

internal class Program
{
    public const int delayBeforeExit = 800;

    private void MenuMainMathCalculator()
    {
        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("MAIN MENU\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Standart calculator\n2) Al-Khwarizmi (data structure and algorithms)\n0) Exit\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    MenuFirstStandartCalculator();
                    break;
                case "2":
                    MenuSecondDataStructureAndAlgorithms();
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("EXIT...");
        Thread.Sleep(delayBeforeExit);
    }

    private void MenuFirstStandartCalculator()
    {
        StandartCalculator standartCalculator = new StandartCalculator();

        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("STANDART CALCULATOR\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Enter values\n2) Output of the history of a math problem\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    Console.WriteLine("Enter a math problem:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    standartCalculator.AlgorithmStandartCalculator();
                    break;
                case "2":
                    Console.WriteLine("Output of the history of a math problem:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    RecordingAndOutputHistory.OutputHistory(UsefulConstants.PathConstants.PathOfHistoryOfStandartCalculator);
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void MenuSecondDataStructureAndAlgorithms()
    {
        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("DATA STRUCTURE AND ALGORITHMS\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Here you can choose the algorithm\n2) Here you can choose data structure\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    Console.WriteLine("Algorithms:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    MenuThirdAlgorithms();
                    break;
                case "2":
                    Console.WriteLine("Data Structures:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    MenuThirdDataStructures();
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void MenuThirdAlgorithms()
    {
        ConstantAlgorithm constantAlgorithm         = new ConstantAlgorithm();
        LogarithmicAlgorithm logarithmicAlgorithm   = new LogarithmicAlgorithm();
        LinearAlgorithm linearAlgorithm             = new LinearAlgorithm();
        QuadraticAlgorithm quadraticAlgorithm       = new QuadraticAlgorithm();
        Linear_logarithmicAlgorithm linear_LA       = new Linear_logarithmicAlgorithm();
        CubicAlgorithm cubicAlgorithm               = new CubicAlgorithm();

        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("ALGORITHMS\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Constant\n2) Logarithmic\n3) Linear\n4) Linear-logarithmic\n5) Quadratic\n6) Cubic\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    Console.WriteLine("Constant:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    constantAlgorithm.StartConstantAlgorithm();
                    break;
                case "2":
                    Console.WriteLine("Binary search:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    logarithmicAlgorithm.StartLogarithmicAlgorithm();
                    break;
                case "3":
                    Console.WriteLine("Factorial:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    linearAlgorithm.Factorial();
                    break;
                case "4":
                    Console.WriteLine("MergeSort:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    linear_LA.MergeSort();
                    break;
                case "5":
                    Console.WriteLine("Quadratic:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    quadraticAlgorithm.BubbleSort();
                    break;
                case "6":
                    Console.WriteLine("Matrix 3x3x3:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    cubicAlgorithm.ThreeDimensionalMatrixOutPut();
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void MenuThirdDataStructures()
    {
        DataStructure.LinkedList<int> intList = new DataStructure.LinkedList<int>();

        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("DATA STRUCTURE\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Linked list\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    LinkedListMenu();
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void LinkedListMenu()
    {
        DataStructure.LinkedList<int> intList = new DataStructure.LinkedList<int>();

        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("LINKED LIST\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Add element in end\n2) Add first element\n3) Remove element\n4) Search element\n5) How many element\n6) Is empty list?\n7) Clear list\n8) Output list\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Enter integer value:");
                    intList.Add(Convert.ToInt32(Console.ReadLine()));
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter integer value (first element):");
                    intList.AddFirst(Convert.ToInt32(Console.ReadLine()));
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter integer value for remove:");
                    if (intList.Remove(Convert.ToInt32(Console.ReadLine())))
                        Console.WriteLine("The object is deleted!");
                    else
                        Console.WriteLine("The object is NOT deleted! Such an object does not exist!");
                        
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Enter integer value for search:");
                    Console.WriteLine($"Contain? [{intList.Contains(Convert.ToInt32(Console.ReadLine()))}]");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine($"How many elements? [{intList.Count}]");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine($"Is list empty? [{intList.IsEmpty}]");
                    Console.ReadKey();
                    break;
                case "7":
                    Console.Clear();
                    intList.Clear();
                    Console.WriteLine($"List is clear!");
                    Console.ReadKey();
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine($"Show list [{intList}]:");
                    foreach (int element in intList)
                    {
                        Console.Write($"{element}, ");
                    }
                    Console.ReadKey();
                    break;
                case "0":
                    IsExit = true;
                    break;
                default:
                    Console.WriteLine("You enter not correct nuber of menu!\nPlease, try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // TODO I don't undestand. WHY the main method of c# procject must be static?
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.MenuMainMathCalculator();
    }
}

