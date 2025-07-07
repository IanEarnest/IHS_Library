namespace IHS_Library;

public class BestPractice1
{
    public BestPractice1()
    {
    }

    // Output true if number is even
    public bool IsEven(int number) => number % 2 == 0;
    public bool Example1_Bad(int number) => number % 2 == 0;
    public bool Example1_Good(int number) 
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
}
