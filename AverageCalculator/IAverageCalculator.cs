namespace AverageCalculator;

internal interface IAverageCalculator
{
    void SetNumbers(int[] numbers);
    double CalculateAverage();

    string GetType();
}