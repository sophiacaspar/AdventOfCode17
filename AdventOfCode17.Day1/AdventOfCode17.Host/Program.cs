using AdventOfCode17.Day1;
using System;

namespace AdventOfCode17.Host
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathToFile = @"C:\Users\sophia.caspar\source\repos\AdventOfCode17\AdventOfCode17.Day1\puzzleInput.txt";
            var fileReader = new FileReader(pathToFile);
            string sequence = fileReader.GetInputFromFile();

            var captcha = new Captcha();
            captcha.ReviewSequence(sequence);
            Console.WriteLine(captcha.GetSum());
        }
    }
}
