using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MaximumValueFinder Refactor 1");
        int maxInt = MaximumValueFinder.FindMaximumValue(10, 5, 7);
        Console.WriteLine("Max Integer: " + maxInt); 

        
        float maxFloat = MaximumValueFinder.FindMaximumValue(4.7f, 8.9f, 3.2f);
        Console.WriteLine("Max Float: " + maxFloat); 

        
        string maxString = MaximumValueFinder.FindMaximumValue("Apple", "Orange", "Banana");
        Console.WriteLine("Max String: " + maxString);
    }
}
    

