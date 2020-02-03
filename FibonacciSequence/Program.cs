using System;
using System.Collections.Generic;

namespace FibonacciSequence
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The first 20 numbers in Fibonnaci Sequence");
      var fibonacciSequence = new List<int> { 1, 1 };

      while (fibonacciSequence.Count < 20)
      {
        var previous = fibonacciSequence[fibonacciSequence.Count - 1];
        var previous2 = fibonacciSequence[fibonacciSequence.Count - 2];
        fibonacciSequence.Add(previous + previous2);
      }

      foreach (var item in fibonacciSequence)
        Console.WriteLine(item);

      Console.WriteLine("What position do you want to know the value?");
      string userNumber = Console.ReadLine();
      int number = int.Parse(userNumber);
      double fibo2 = (Math.Pow((1 + Math.Sqrt(5)) / 2, number) - Math.Pow((1 - Math.Sqrt(5)) / 2, number)) / Math.Sqrt(5);

      Console.WriteLine(Math.Round(fibo2));
    }
  }
}
