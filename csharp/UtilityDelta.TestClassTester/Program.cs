using UtilityDelta.TestClassTester;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World: " + TestClassInterop.DoThings(44.33F));
    }
}