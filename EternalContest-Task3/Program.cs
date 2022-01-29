using System;

namespace EternalContest_Task3
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      int theNumberOfEmployees = int.Parse(vs[0]);
      int timeToLeaveTheOffice = int.Parse(vs[1]);
      input = Console.ReadLine();
      vs = input.Split(' ');
      int[] floorNumbers = new int [vs.Length];
      for (int i = 0; i < vs.Length; i++)
      {
        floorNumbers[i] = int.Parse(vs[i]);
      }
      int outgoingEmployeeNumber = int.Parse(Console.ReadLine()) - 1 ;
      int numberOfFlightsOfStairs = 0;
      if (floorNumbers[outgoingEmployeeNumber] - floorNumbers[0] <= timeToLeaveTheOffice)
      {
        for (int i = 1; i < floorNumbers.Length; i++)
        {
          numberOfFlightsOfStairs += floorNumbers[i] - floorNumbers[i - 1];
        }
      }
      else 
      {
        numberOfFlightsOfStairs += floorNumbers[outgoingEmployeeNumber] - floorNumbers[0];
        for (int i = 1; i < floorNumbers.Length; i++)
        {
          if (i == outgoingEmployeeNumber + 1)
          {
            numberOfFlightsOfStairs += floorNumbers[i] - floorNumbers[i-2];
          }
          else if (i != outgoingEmployeeNumber)
          {
            numberOfFlightsOfStairs += floorNumbers[i] - floorNumbers[i - 1];
          }
          else
          {
            continue;
          }
        }
      }
      Console.WriteLine(numberOfFlightsOfStairs);
      Console.ReadLine();
    }
  }
}
