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
        MyLinkedList<int> intLinkedList = new MyLinkedList<int>(1, "Dima");
        MyLinkedList<string> stringLinkedList = new MyLinkedList<string>("one", "Dima");

        MyLinkedList<int>.code = 404;
        MyLinkedList<string>.code = "four hundred four";

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
                    Console.WriteLine("Linked list:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.Clear();
                    Console.WriteLine($"ID: {MyLinkedList<int>.code}, Name: {MyLinkedList<string>.code}");
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

