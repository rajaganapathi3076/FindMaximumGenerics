using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MaximumValueFinder Refactor 2");
        MaximumValueFinder<int> intFinder = new MaximumValueFinder<int>(10, 5, 7);
        int maxInt = intFinder.FindMaximum();
        Console.WriteLine("Max Integer: " + maxInt); 

     
        MaximumValueFinder<float> floatFinder = new MaximumValueFinder<float>(4.7f, 8.9f, 3.2f);
        float maxFloat = floatFinder.FindMaximum();
        Console.WriteLine("Max Float: " + maxFloat); 


       
        MaximumValueFinder<string> stringFinder = new MaximumValueFinder<string>("Apple", "Orange", "Banana");
        string maxString = stringFinder.FindMaximum();
        Console.WriteLine("Max String: " + maxString);
    }
}
    

