using AdventOfCode17.Day1;
using System;

namespace AdventOfCode17.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var captcha = new Captcha();
            var sequence = 1221;
            captcha.ReviewSequence(sequence);
            Console.WriteLine(captcha.GetSum());
        }
    }
}
