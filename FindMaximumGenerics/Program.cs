using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FindMaximumString UC2");
        string max1 = MaximumStringFinder.FindMaximumString("Apple", "Peach", "Banana");
        Console.WriteLine("Max String: " + max1); 

        
        string max2 = MaximumStringFinder.FindMaximumString("Apple", "Orange", "Banana");
        Console.WriteLine("Max String: " + max2); 

       
        string max3 = MaximumStringFinder.FindMaximumString("Grapes", "Mango", "Pineapple");
        Console.WriteLine("Max String: " + max3);
    }
}
    

