/*
IHS_Library
THIS IS A CONSOLE PROJECT WITH A LIBRARY
Projects:
    IHS_Library - My main class library/ utility library + console
    IHS_Library_Extended - stripe and such other libraries...
    IHS_Library_Simple - no dependancies...
    IHS_Library_Tests - console tests
 
IHS_Library_Extended uses IHS_Library
IHS_Library uses IHS_Library_Simple
...

Classes
    HelloWorld.cs - SayHelloWorld + version
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

    static void Main(string[] args)
    {
        Console.WriteLine("Hello world and such...");

        HelloWorld();
        Numbers();
    }

    // Calling libraries
    // Print Hello World
    public static void HelloWorld()
    {
        helloWorld.SayHelloWorld();
    }
    // Do numbers stuff
    public static void Numbers()
    {
        Console.WriteLine("Do numbers stuff...");

        // Check even number
        Console.WriteLine($"\tNumber 2 is even? {numbers.IsEven(2)}");
        Console.WriteLine($"\tNumber 3 is even? {numbers.IsEven(3)}");
        Console.WriteLine($"\tNumber 4 is even? {numbers.IsEven(4)}");
        Console.WriteLine($"\tNumber 5 is even? {numbers.IsEven(5)}");
    }
    //... other libs
}
