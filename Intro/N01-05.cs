using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalCSharp
{
    class N01_05
    {
        //No.01
        int add(int param1, int param2)
        {
            return (param1 + param2);
        }

        //No.02
        int centuryFromYear(int year)
        {
            return ((year - 1) / 100 + 1);
        }
        int centuryFromYear1(int year)
        {
            return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(year) / 100));
        }

        //No.03
        bool checkPalindrome(string inputString)
        {
            string result = new string(inputString.Reverse().ToArray());
            return (inputString == result);
        }
        bool checkPalindrome1(string myString)
        {
            return myString.SequenceEqual(myString.Reverse());
        }

        //No.04
        int adjacentElementsProduct(int[] inputArray)
        {
            int m = int.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                m = Math.Max(m, inputArray[i] * inputArray[i + 1]);
            }
            return m;
        }
    }
}
