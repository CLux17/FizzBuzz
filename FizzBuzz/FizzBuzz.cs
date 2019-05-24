using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (IsMultipleOf3(num) && IsMultipleOf5(num))
            {
                return "FizzBuzz";
            }
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }
                return num.ToString();
        }

        private bool IsMultipleOf3(int numberToCHeck)
        {
            return numberToCHeck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberToCHeck)
        {
            return numberToCHeck % 5 == 0;
        }
    }
}
