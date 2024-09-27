using System.IO;
using System.Text;

public class RecordingAndOutputHistory
{
    public static void RecordingHistory(string mathProblem, string path)
    {
        // TODO Make sense of this pile of code
        // create new file (what is it? using?)
        //using (FileStream fs = fileInfo.Create())
        //{
        //    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
        //    fs.Write(info, 0, info.Length);
        //}

        if (!Directory.Exists(UsefulConstants.PathConstants.PathDirectoryOfHistoryOfStandartCalculator))
        {
            Directory.CreateDirectory(UsefulConstants.PathConstants.PathDirectoryOfHistoryOfStandartCalculator);
        }

        File.AppendAllTextAsync(path, mathProblem);
    }

    public static void OutputHistory(string path)
    {
        string[] allFileString;

        if (File.Exists(path))
        {
            allFileString = File.ReadAllLines(path);

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
            Console.WriteLine($"File {path} doesn't exist!");
            Console.ReadKey();
        }
    }
}

