using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode17.Day1
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
