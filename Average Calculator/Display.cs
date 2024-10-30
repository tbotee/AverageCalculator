namespace Average_Calculator;

public static class Display
{
    public static void DisplayMessage(string? file, string type, double average)
    {
        if (file != null)
        {
            Console.WriteLine(file);
        }
        Console.WriteLine($"{type}: {average:F2}");
    }

    public static void DisplayNewLine()
    {
        Console.WriteLine();
    }
}