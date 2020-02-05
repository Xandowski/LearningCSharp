using System;

namespace FactorialProgram
{
  class Program
  {
    static int factorialNumber, fact = 1, result;
    static void Main(string[] args)
    {
      Console.WriteLine("Factorial of which number you want to know?");
      factorialNumber = Int32.Parse(Console.ReadLine());
      result = FactorialCalculation(factorialNumber);
      Console.Write(factorialNumber + "! = ");
      Console.Write(result + " ");
    }

    // private static void Factorial(int number)
    // {
    //   Console.Write(number + "! = ");
    //   for (int i = number; i > 1; i--)
    //   {
    //     number = number * (i - 1);

    //   }
    //   Console.Write(number + " ");
    // }

    private static int FactorialCalculation(int factorialNumber)
    {
      if (factorialNumber > 0)
      {
        fact = factorialNumber * FactorialCalculation(factorialNumber - 1);
      }
      return fact;
    }
  }
}
