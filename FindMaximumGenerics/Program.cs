﻿using FindMaximumGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MaximumValueFinder  UC4");
        MaximumValueFinder<int> intFinder = new MaximumValueFinder<int>(10, 5, 7, 12, 3);
        int maxInt = intFinder.FindMaximum();
        Console.WriteLine("Max Integer: " + maxInt); 

        
        MaximumValueFinder<float> floatFinder = new MaximumValueFinder<float>(4.7f, 8.9f, 3.2f, 6.1f);
        float maxFloat = floatFinder.FindMaximum();
        Console.WriteLine("Max Float: " + maxFloat); 

       
        MaximumValueFinder<string> stringFinder = new MaximumValueFinder<string>("Apple", "Orange", "Banana", "Grapes");
        string maxString = stringFinder.FindMaximum();
        Console.WriteLine("Max String: " + maxString);
    }
}
    

