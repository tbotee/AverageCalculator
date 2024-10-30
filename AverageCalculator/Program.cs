
using AverageCalculator;

namespace AverageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meanAverage = new MeanAverage();
            var modeAverage = new ModeAverage();

            for (var i  = 1; i <=2 ; i++)
            {
                var file = $"numbers{i}.txt";
                var numbers = FileReader.ReadFile(file);
                ShowAverage(meanAverage, numbers, file);
                ShowAverage(modeAverage, numbers, null);
                Display.DisplayNewLine();
            }
        }

        private static void ShowAverage(IAverageCalculator averageCalculator, int[] numbers, string? file)
        {
            averageCalculator.SetNumbers(numbers);
            Display.DisplayMessage(file, averageCalculator.GetType(), averageCalculator.CalculateAverage());
        }
    }
}

