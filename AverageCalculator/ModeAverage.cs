namespace AverageCalculator;

public class ModeAverage: IAverageCalculator
{
    public int[]? Numbers;

    public void SetNumbers(int[] numbers)
    {
        Numbers = numbers;
    }

    public double CalculateAverage()
    {
        if (Numbers == null || Numbers.Length == 0)
            throw new InvalidOperationException("No numbers to calculate the average.");

        // do logic of Mode Average
        return Numbers.Average();
    }

    public new string GetType()
    {
        return "Mode";
    }
}