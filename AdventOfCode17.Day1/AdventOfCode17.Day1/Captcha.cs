using System;

namespace AdventOfCode17.Day1
{
    public class Captcha
    {

        public int GetSumFromCheckingOneDigitAhead(string sequence)
        {
            return ReviewSequence(sequence, 1);
        }

        public int GetSumFromCheckingHalfLengthDigitAhead(string sequence)
        {
            return ReviewSequence(sequence, sequence.Length/2);
           
        }

        private int ConvertToInt(char digit)
        {
            return (int)Char.GetNumericValue(digit);
        }

        private int ReviewSequence(string sequence, int indexForward)
        {
            int sum = 0;
            var digits = sequence.ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == digits[indexForward])
                {
                    sum += ConvertToInt(digits[i]);
                }

                indexForward++;

                // set indexForward to continue the check in a circular way
                if (indexForward == digits.Length)
                {
                    indexForward = 0;
                }

            }
            return sum;
        }
    }
}
