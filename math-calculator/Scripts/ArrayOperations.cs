using System;

public class ArrayOperations
{
    public static List<int> GenerateArray()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            numbers.Add(random.Next(1, 100));
        }

        return numbers;
    }

    public static List<int> GenerateArray(int lenghtArray)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < lenghtArray; i++)
        {
            numbers.Add(random.Next(1, 100));
        }

        return numbers;
    }

    public static void OutPutArray(List<int> numbers, string text)
    {
        int count = 0;
        int countForNextLine = 0;

        if (numbers.Count <= 10)        countForNextLine = 0; 
        else if (numbers.Count <= 100)  countForNextLine = 10;
        else                            countForNextLine = 30;

        Console.WriteLine($"\n{text}:");

        foreach (int element in numbers)
        {
            count++;
            Console.Write($"{element}\t");
            if (count == countForNextLine)
            {
                Console.Write($"\n");
                count = 0;
            }
        }
        Console.Write($"\n");
    }

    public static void BinarySearch(int key, List<int> numbers)
    {
        int numberOfIterations = 0;
        int low = 0;
        int mid = 0;
        int high = numbers.Count - 1;

        bool IsKeyFound = false;

        while (low <= high)
        {
            numberOfIterations++;
            mid = low + (high - low) / 2;

            if (key < numbers[mid]) high = mid - 1;
            else if (key > numbers[mid]) low = mid + 1;
            else
            {
                IsKeyFound = true;
                break;
            }
        }

        Console.WriteLine("\nBinary search:");
        if (IsKeyFound)
        {
            Console.WriteLine($"Key = {mid + 1} (count of iterations = {numberOfIterations})");
        }
        else
        {
            Console.WriteLine($"Key not found! (count of iterations = {numberOfIterations})");
        }
    }


    public static void LinearSearch(int key, List<int> numbers, string textAfterBefore)
    {
        int numberOfIterations = 0;

        bool IsKeyFound = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            numberOfIterations++;

            if (key == numbers[i])
            {
                IsKeyFound = true;
                break;
            }
        }

        Console.WriteLine($"\nLinear search {textAfterBefore}:");
        if (IsKeyFound)
        {
            Console.WriteLine($"Key = {numberOfIterations} (count of iterations = {numberOfIterations})");
        }
        else
        {
            Console.WriteLine($"Key not found! (count of iterations = {numberOfIterations})");
        }
    }
}