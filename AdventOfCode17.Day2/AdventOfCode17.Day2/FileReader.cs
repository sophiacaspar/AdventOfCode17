using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode17.Day2
{
    public class FileReader
    {
        private string _pathToFile;
        private List<String> _rows;

        public FileReader(string pathToFile)
        {
            _pathToFile = pathToFile;
        }

        public void GetInputFromFile()
        {
            _rows = new List<string>(); 
            try
            {
                var rows = File.ReadAllLines(_pathToFile);
                foreach (var row in rows)
                {
                    _rows.Add(row);

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

