using System;

namespace Pyramid
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite a number: ");
      int number = Int32.Parse(Console.ReadLine());
      DrawPyramid(number);
    }

    private static void DrawPyramid(int n)
    {
      for (int i = 0, j = n; i < n; i++, j--)
      {
        int space = n + (n - 1);
        for (int k = 0; k < space; k++)
        {
          if (k < j - 1)
          {
            Console.Write(" ");
            space--;
          }
          else
          {
            Console.Write("*");
          }

        }

        Console.WriteLine();
      }
    }
  }
}
