/*
IHS_Library
THIS IS A CONSOLE PROJECT WITH A LIBRARY
Projects:
    IHS_Library - My main class library/ utility library + console
    IHS_Library_Extended - stripe and such other libraries...
    IHS_Library_Simple - no dependancies... - Core?
    IHS_Library_Tests - console tests
 
IHS_Library_Extended uses IHS_Library
IHS_Library uses IHS_Library_Simple
...

Classes
    HelloWorld.cs - SayHelloWorld + version

TODO examples
TODO nullables
TODO performance examples
TODO best practise examples

++++++++ CURRENT EXPECTED OUTPUT
Hello world and such...
Hello, World! - IHS_Library - V0.1
Do numbers stuff...
        Number 2 is even? True
        Number 3 is even? False
        Number 4 is even? True
        Number 5 is even? False
        Nulls - is even? True
        Nulls - try nulls: hi from null string
        PerformanceExamples1 - is even? True
        BestPractice1 - is even? True
++++++++
*/

namespace IHS_Library;
public static class Program
{
    // Library constants
    public const string version = "V0.1";
    public const string libNameSpace = "IHS_Library";
    public const string helloWorldString = $"Hello, World! - {libNameSpace} - {version}";


    // Library classes
    public static HelloWorld helloWorld = new();
    public static Numbers numbers = new();
    public static Nulls nulls = new();
    public static PerformanceExamples1 performanceExamples1 = new();
    public static BestPractice1 bestPractice1 = new();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello world and such...");

        HelloWorld();
        Numbers();
        Nulls();
        PerformanceExamples1();
        BestPractice1();
    }

    // Calling libraries

    // Print Hello World - using HelloWorld class
    public static void HelloWorld()
    {
        helloWorld.SayHelloWorld();
    }

    // Print Numbers stuff - using Numbers class
    public static void Numbers()
    {
        Console.WriteLine("Do numbers stuff...");

        // Check even number
        Console.WriteLine($"\tNumber 2 is even? {numbers.IsEven(2)}");
        Console.WriteLine($"\tNumber 3 is even? {numbers.IsEven(3)}");
        Console.WriteLine($"\tNumber 4 is even? {numbers.IsEven(4)}");
        Console.WriteLine($"\tNumber 5 is even? {numbers.IsEven(5)}");
    }

    // Print Nulls stuff - using Nulls class
    public static void Nulls()
    {
        Console.WriteLine($"\tNulls - is even? {nulls.IsEven(2)}");
        Console.WriteLine($"\tNulls - try nulls: {nulls.TryNulls()}");
    }

    // Print Performance Examples
    public static void PerformanceExamples1()
    {
        Console.WriteLine($"\tPerformanceExamples1 - is even? {performanceExamples1.IsEven(2)}");
    }

    // Print Best Practice Examples
    public static void BestPractice1()
    {
        Console.WriteLine($"\tBestPractice1 - is even? {bestPractice1.IsEven(2)}");
    }
    //... other libs
}
