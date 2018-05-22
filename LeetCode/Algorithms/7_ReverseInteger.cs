using System;
using System.Linq;

namespace Algorithms
{
    //7. Reverse Integer
    //Given a 32-bit signed integer, reverse digits of an integer.
    //Example 1:
    //Input: 123
    //Output: 321
    //Example 2:
    //Input: -123
    //Output: -321
    //Example 3:
    //Input: 120
    //Output: 21
    //Note:
    //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2n31,  2n31 − 1]. 
    //For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

    public static class ReverseInteger7
    {
        public static int Reverse(int x)
        {
            if (x == 0) return 0;

            var listChars = x.ToString()
                .TrimEnd('0')
                .ToList();

            if (listChars.Contains('-'))
            {
                listChars.RemoveAt(0);
                listChars.Add('-');
            }

            listChars.Reverse();

            var resultString = new String(listChars.ToArray());

            if (!int.TryParse(resultString, out int result))
                return 0;

            return result;
        }
    }
}
