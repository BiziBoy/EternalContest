using System;
//Ваня принес на кухню рулет, который он хочет разделить с коллегами. 
//Для этого он хочет разрезать рулет на ﻿N равных частей. 
//Вам дано число ﻿N﻿, требуется сказать, каким минимальным числом разрезов можно обойтись.
namespace EternalContest_Task2
{
  class Program
  {
    static void Main(string[] args)
    {
      int N = int.Parse(Console.ReadLine());
      if (N % 2 == 0)
      {
        Console.WriteLine(N / 2);
      }
      else if(N != 1)
      {
        Console.WriteLine(N / 2 + 1);
      }
      else
      {
        Console.WriteLine(0);
      }
      Console.ReadLine();
    }
  }
}
