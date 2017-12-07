using System;

namespace AdventOfCode17.Day1
{
    public class Captcha
    {
        private int _sum;
        private int _startsum = 0;

        public int GetSumFromCheckingOneDigitAhead(string sequence)
        {
            _sum = _startsum;
            ReviewSequence(sequence, 1);
            return _sum;
        }

        public int GetSumFromCheckingHalfLengthDigitAhead(string sequence)
        {
            _sum = _startsum;
            ReviewSequence(sequence, sequence.Length/2);
            return _sum;
        }

        private void AddSum(char digit)
        {
            _sum = _sum + (int)Char.GetNumericValue(digit); ;
        }

        public void ReviewSequence(string sequence, int indexForward)
        {
            var digits = sequence.ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == digits[indexForward])
                {
                    AddSum(digits[i]);
                }

                indexForward++;

                // set indexForward to continue the check in a circular way
                if (indexForward == digits.Length)
                {
                    indexForward = 0;
                }

            }

        }
    }
}
