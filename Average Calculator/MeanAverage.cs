namespace Average_Calculator;

public class MeanAverage : IAverageCalculator
{
    private int[]? _numbers;

    public int[] Numbers
    {
        set => _numbers = value;
    }

    public double CalculateAverage()
    {
        if (_numbers == null || _numbers.Length == 0)
            throw new InvalidOperationException("No numbers to calculate the average.");

        // do logic of Mean Average
        return _numbers.Average();
    }

    public string GetType()
    {
        return "Mean";
    }
}