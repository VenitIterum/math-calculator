using System.IO;
using System.Text;

public class RecordingAndOutputHistory
{
    private const string PathOfHistoryOfStandartCalculator = "../../../History/HistoryOfStandartCalculator.txt";

    public void RecordingHistoryOfStandartCalculator(string mathProblem)
    {
        // create new file (what is it? using?)
        //using (FileStream fs = fileInfo.Create())
        //{
        //    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
        //    fs.Write(info, 0, info.Length);
        //}

        File.AppendAllTextAsync(PathOfHistoryOfStandartCalculator, mathProblem);
    }

    public void OutputHistoryOfStandartCalculator()
    {
        string[] allFileString;

        if (File.Exists(PathOfHistoryOfStandartCalculator))
        {
            allFileString = File.ReadAllLines(PathOfHistoryOfStandartCalculator);

            Console.Clear();
            foreach (string element in allFileString)
            {
                Console.WriteLine(element);
            }
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

