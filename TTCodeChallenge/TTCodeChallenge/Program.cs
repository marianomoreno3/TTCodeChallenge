using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCodeChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter the first number: ");
      var number1 = Console.ReadLine().ToCharArray();
      Console.WriteLine();

      Console.Write("Please enter the second number: ");
      var number2 = Console.ReadLine().ToCharArray();
      Console.WriteLine("\n");

      var ops = new Operations();

      Console.WriteLine("The result is: " + ops.Sum(number1, number2));

      Console.ReadKey();
    }
  }
}
