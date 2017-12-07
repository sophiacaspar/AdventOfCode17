using System;

namespace AdventOfCode17.Day1
{
    public class Captcha
    {
        private int _sum = 0;

        public int GetSum()
        {
            return _sum;
        }

        private void AddSum(char digit)
        {
            _sum = _sum + (int)Char.GetNumericValue(digit); ;
        }

        public void ReviewSequence(string sequence)
        {
            var digits = sequence.ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (i != (digits.Length - 1) && (digits[i] == digits[i + 1]))
                {
                    AddSum(digits[i]);
                }
                else if (i == (digits.Length -1) && (digits[i] == digits[0]))
                {
                    AddSum(digits[i]);
                }
                else
                {
                    continue;
                }
            }
        }

        public void ReviewSequenceHalfLengthAhead(string sequence, int indexForward)
        {
            var digits = sequence.ToCharArray();

        }
    }
}
