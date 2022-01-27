using System;
//Костя подключен к мобильному оператору «Мобайл». 
//Абонентская плата Кости составляет ﻿AA﻿ рублей в месяц. 
//За эту стоимость Костя получает ﻿BB﻿ мегабайт интернет-трафика. 
//Если Костя выйдет за лимит трафика, то каждый следующий мегабайт будет стоить ему ﻿CC﻿ рублей.
//Костя планирует потратить ﻿DD﻿ мегабайт интернет-трафика в следующий месяц. 
//Помогите ему сосчитать, во сколько рублей ему обойдется интернет.
namespace EternalContest
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      byte costTariff_A = byte.Parse(vs[0]);
      byte fareAmount_B = byte.Parse(vs[1]);
      byte theCostOfEachExtraMegabyte_C = byte.Parse(vs[2]);
      byte internetTrafficSize_D = byte.Parse(vs[3]);
      if (internetTrafficSize_D <= fareAmount_B)
      {
        Console.WriteLine(costTariff_A);
      }
      else
      {
        Console.WriteLine(costTariff_A + (internetTrafficSize_D - fareAmount_B) * theCostOfEachExtraMegabyte_C);
      }
      Console.ReadLine();
    }
  }
}
