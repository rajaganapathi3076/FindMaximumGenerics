using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FindMaximumGenericsUC1");
        float max1 = MaximumNumberFinder.FindMaximumNumber(10.5f, 5.2f, 7.8f);
        Console.WriteLine("Max Number: " + max1); 

       
        float max2 = MaximumNumberFinder.FindMaximumNumber(4.7f, 8.9f, 3.2f);
        Console.WriteLine("Max Number: " + max2); 

       
        float max3 = MaximumNumberFinder.FindMaximumNumber(2.1f, 6.3f, 9.7f);
        Console.WriteLine("Max Number: " + max3);
    }
}
    

