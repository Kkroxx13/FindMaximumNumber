    using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNumberProject
{
   public class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if(firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if(secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if(thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("All the number are same");
        }

        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("All the number are same");
        }

        public static string MaximumStringNumber(string firstValue, string  secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("All the number are same");
        }
    }
}
