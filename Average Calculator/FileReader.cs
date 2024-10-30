namespace Average_Calculator;

using System.IO;
using System.Linq;

public static class FileReader
{
    public  static int[] ReadFile(string filePath)
    {
        var numbers = File.ReadAllLines(filePath)
            .Select(int.Parse)
            .ToArray();
        return numbers;
    }
}