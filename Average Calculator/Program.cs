
using Average_Calculator;

var meanAverage = new MeanAverage();
var modeAverage = new ModeAverage();

for (var i  = 1; i <=2 ; i++)
{
    var file = $"numbers{i}.txt";
    var numbers = FileReader.ReadFile(file);
    
    meanAverage.Numbers = numbers;
    Display.DisplayMessage(file, meanAverage.GetType(), meanAverage.CalculateAverage());
    
    modeAverage.Numbers = numbers;
    Display.DisplayMessage(null, modeAverage.GetType(), modeAverage.CalculateAverage());

    Display.DisplayNewLine();
}