using System;
using MathStanadrtCalculator;
using DataStructureAndAlgorithms;


internal class Program
{
    const int delayBeforeExit = 800;

    private static void MenuMainMathCalculator()
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

        Console.WriteLine("EXIT.");
        Thread.Sleep(delayBeforeExit);
        Console.Clear();
        Console.WriteLine("EXIT..");
        Thread.Sleep(delayBeforeExit);
        Console.Clear();
        Console.WriteLine("EXIT...");
        Thread.Sleep(delayBeforeExit);
    }

    private static void MenuFirstStandartCalculator()
    {
        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("STANDART CALCULATOR\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) Enter values\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    Console.WriteLine("Enter a math problem:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    StandartCalculator.AlgorithmStandartCalculator();
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

    private static void MenuSecondDataStructureAndAlgorithms()
    {
        bool IsExit = false;
        var numOfMenu = "0";

        while (!IsExit)
        {
            Console.Clear();
            Console.Write("DATA STRUCTURE AND ALGORITHMS\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nChoose:\n1) There is nothing here right now!\n0) Back\nEnter:");
            numOfMenu = Console.ReadLine();
            Console.Clear();

            switch (numOfMenu)
            {
                case "1":
                    //Console.WriteLine("Enter a math problem:\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    DataStructureAndAlgorithmsClass.InternalMethod();
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

    //I don't undestand. WHY the main method of c# procject must be static?
    private static void Main(string[] args)
    {
        MenuMainMathCalculator();
    }
}

