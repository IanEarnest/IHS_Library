namespace IHS_Library;

public class PerformanceExamples1
{
    public PerformanceExamples1()
    {
    }

    // Output true if number is even
    public bool IsEven(int number) => number % 2 == 0;
    public bool Example1_Slow(int number)
    {
        int inputNumber = number;
        int modifiedNumber = inputNumber % 2;
        if (number % 2 == 0)
        {
            return true;
        }
        else if (number % 2 != 0)
        {
            return false;
        }
        else
        {
            throw new Exception("Invalid number");
        }
    }
    public bool Example1_Fast(int number)
    {
        return number % 2 == 1;
    }
}
