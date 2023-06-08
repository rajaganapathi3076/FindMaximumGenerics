using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FindMaximumGenericsUC1");
        int max1 = MaximumNumberFinder.FindMaximumNumber(10, 5, 7);
        Console.WriteLine("Max Number: " + max1); // Output: Max Number: 10

        // Test Case 2: Max Number at 2nd position
        int max2 = MaximumNumberFinder.FindMaximumNumber(4, 8, 3);
        Console.WriteLine("Max Number: " + max2); // Output: Max Number: 8

        // Test Case 3: Max Number at 3rd position
        int max3 = MaximumNumberFinder.FindMaximumNumber(2, 6, 9);
        Console.WriteLine("Max Number: " + max3); // Output: Max Number: 9
    }
}

    

