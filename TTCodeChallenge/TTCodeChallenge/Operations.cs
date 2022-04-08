using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCodeChallenge
{
  public class Operations
  {
    public string Sum(char[] number1, char[] number2)
    {
      long idx1 = number1.Length - 1;
      long idx2 = 0;

      int digit1 = 0;
      int digit2 = 0;
      int carry = 0;
      int actualValue = 0;

      string result = String.Empty;

      bool finish = false;

      while (!finish)
      {
        if (idx1 >= 0)
        {
          digit1 = int.Parse(number1[idx1].ToString());
        }

        if (idx2 < number2.Length)
        {
          digit2 = int.Parse(number2[idx2].ToString());
        }

        actualValue = digit1 + digit2 + carry;
        carry = 0;

        if (actualValue >= 10)
        {
          carry = 1;
          actualValue = actualValue % 10;
        }

        result = String.Concat(actualValue.ToString(), result);

        // Reset values
        digit1 = 0;
        digit2 = 0;

        // Update indexes
        idx1--;
        idx2++;

        finish = idx1 < 0 && idx2 >= number2.Length;
      }

      if (carry > 0)
      {
        result = String.Concat(carry.ToString(), result);
      }

      return result;
    }
  }
}
