using System;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            int output = 0;

            var isNullOrEmpty = String.IsNullOrEmpty(input);
            var hasCommas = input.Contains(',');
            
            if (hasCommas)
            {
                output = HandleStringWithCommas(input);
            }
            if (isNullOrEmpty && !hasCommas)
            {
                output = 0;
            }
            if (!isNullOrEmpty && !hasCommas)
            { 
                output = Convert.ToInt32(input);
            } 
            
            return output;
        }

        public int HandleStringWithCommas(string input)
        {
            var sum = 0;
            
            var inputList = input.Replace("\n",",").Split(",");

            foreach (var number in inputList)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}