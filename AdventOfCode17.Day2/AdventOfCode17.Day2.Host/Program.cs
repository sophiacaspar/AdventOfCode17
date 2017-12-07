using System;
using System.Collections.Generic;

namespace AdventOfCode17.Day2.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = @"C:\Users\sophia.caspar\source\repos\AdventOfCode17\AdventOfCode17.Day2\dataInput.txt";
            var fileReader = new FileReader(pathToFile);
            var input = fileReader.GetInputFromFile();

            var checksum = new Checksum();
            Console.WriteLine(checksum.CalculateChecksum(input));
        }
    }
}
