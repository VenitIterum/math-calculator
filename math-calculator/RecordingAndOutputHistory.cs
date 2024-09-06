public class RecordingAndOutputHistory
{
    private const string PathOfHistoryOfStandartCalculator = "History/HistoryOfStandartCalculator.txt";

    public void RecordingHistoryOfStandartCalculator(string mathProblem)
    {
        FileInfo fileOfHistoryOfStandartCalculator = new FileInfo(PathOfHistoryOfStandartCalculator);

        if (!fileOfHistoryOfStandartCalculator.Exists)
        {
            fileOfHistoryOfStandartCalculator.Create();
        }

        File.AppendAllTextAsync(PathOfHistoryOfStandartCalculator, mathProblem);
    }

    public void OutputHistoryOfStandartCalculator()
    {
        string[] allFileString;

        if (File.Exists(PathOfHistoryOfStandartCalculator))
        {
            allFileString = File.ReadAllLines(PathOfHistoryOfStandartCalculator);
            Console.Clear();
            Console.WriteLine(allFileString);
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"File {PathOfHistoryOfStandartCalculator} doesn't exist!");
            Console.ReadKey();
        }
    }
}

