/*
Console program to test libraries


DONE
    Project Reference
        IHS_Library - My main class library + console
        IHS_Library_Extended - stripe and such other libraries...
        IHS_Library_Simple - no dependancies...
        IHS_Library_Tests - console tests

TODO
    ... examples
*/

//using IHS_Library;
//using IHS_Library_Simple;
//using IHS_Library_Extended;
//using IHS_Library_Tests;



// Constants...
string version = "V0.1";
string libNameSpace = "IHS_Library_Tests";
string helloWorldString = $"Hello, World! - {libNameSpace} - {version}";

Console.WriteLine($"{helloWorldString}");
CheckAllLibs();
RunTests();




void CheckAllLibs()
{
    Console.WriteLine("Checking libraries");

    // IHS_Library
    // Static
    Console.WriteLine("\tChecking IHS_Library...");
    IHS_Library.Program.HelloWorld(); // Init
    Console.WriteLine();

    //IHS_Library_Simple
    Console.WriteLine("\tChecking IHS_Library_Simple...");
    IHS_Library_Simple.Program IHSLS = new(); // Init
    IHSLS.HelloWorld();
    Console.WriteLine();

    //IHS_Library_Extended
    Console.WriteLine("\tChecking IHS_Library_Extended...");
    IHS_Library_Extended.Program IHSLE = new(); // Init
    IHSLE.HelloWorld();
    Console.WriteLine();
}

void RunTests()
{
    Console.WriteLine("RunTests");

    // IHS_Library_Tests
    Console.WriteLine("\tRun tests1 - test 1...");
    IHS_Library_Tests.Tests1 IHSLT = new(); // Init
    IHSLT.RunTest1();
}

