using System;
using System.Linq;

namespace EternalContest_Task4
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      int amountOfNnumbers = int.Parse(vs[0]);
      int numberOfOperations = int.Parse(vs[1]);
      int[] operations = new int[numberOfOperations];
      input = Console.ReadLine();
      vs = input.Split(' ');
      int[] numbersOnPaper = new int[vs.Length];
      long sumOld = 0;
      for (int i = 0; i < vs.Length; i++)
      {
        numbersOnPaper[i] = int.Parse(vs[i]);
        sumOld += numbersOnPaper[i];
      }
      for (int i = 0; i < operations.Length; i++)
      {
        operations[i] = numbersOnPaper.Max();
      }
      int maxBitDepth = 0;
      int maxBitDepthTemp1 = 0;
      int[] minNumbersOnPaper = new int[numbersOnPaper.Length];
      int[] TempNumbersOnPaper = new int[numbersOnPaper.Length];
      //код ниже - нахожу максимальную разрядность в массиве
      for (int i = 0; i < numbersOnPaper.Length; i++)
      {
        TempNumbersOnPaper[i] = numbersOnPaper[i];
        while (TempNumbersOnPaper[i] > 0)
        {
          TempNumbersOnPaper[i] = TempNumbersOnPaper[i] / 10;
          maxBitDepthTemp1++;
        }
        if (maxBitDepthTemp1 > maxBitDepth)
        {
          maxBitDepth = maxBitDepthTemp1;
        }
        for (int j = 0; j < operations.Length; j++)
        {
          if (numbersOnPaper[i] < operations[j])
          {
            operations[j] = numbersOnPaper[i];
            minNumbersOnPaper[maxBitDepthTemp1] = numbersOnPaper[i];
          }
        }
        maxBitDepthTemp1 = 0;
      }

    }
  }
}
