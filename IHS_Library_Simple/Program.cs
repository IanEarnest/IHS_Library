/*
IHS_Library_Simple
THIS IS A CLASS LIBRARY AND DOES NOT RUN AS A CONSOLE PROGRAM
...

Classes
    HelloWorld.cs - SayHelloWorld + version
*/

namespace IHS_Library_Simple;

public class Program
{
    // Library constants
    public const string version = "V0.1";
    public const string libNameSpace = "IHS_Library_Simple";
    public const string helloWorldString = $"Hello, World! - {libNameSpace} - {version}";


    // Library classes
    HelloWorld helloWorld = new();

    public Program()
    {
        //Console.WriteLine($"{libNameSpace} loading...");
    }


    // Calling libraries
    public void HelloWorld()
    {
        helloWorld.SayHelloWorld();
    }

    //... other libs
}
