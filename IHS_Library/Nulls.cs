namespace IHS_Library;

public class Nulls
{
    public Nulls()
    {
    }

    // Output true if number is even
    public bool IsEven(int number) => number % 2 == 0;

    public string TryNulls()
    {
        //project nullability enable
        string? myString = null;
        //null conditional
        myString?.ToString();
        myString ??= "hi from null string";
        //null coalescing ??, conditional ?., coalescing assignment ??=
        
        return myString;
    }
}
