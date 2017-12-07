using System;
using System.IO;

namespace AdventOfCode17.Day2
{
    public class FileReader
    {
        private string _pathToFile;

        public FileReader(string pathToFile)
        {
            _pathToFile = pathToFile;
        }

        public string GetInputFromFile()
        {
            try
            {
                return File.ReadAllText(_pathToFile);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                return "";
            }

        }
    }
}

