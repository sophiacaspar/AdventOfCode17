using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode17.Day2
{
    public class Checksum
    {
        private List<int> _differences;

        public int CalculateChecksum(List<string> rows)
        {
            _differences = new List<int>();

            foreach (string row in rows)
            {
                var values = ConvertStringListToIntList(row);
                _differences.Add(GetDifferenceOfMinAndMaxValue(values));
            }
            return _differences.Sum();
        }

        public List<int> ConvertStringListToIntList(string row)
        {
            var test = row.Split().Select(int.Parse).ToArray();
            return row.Split().Select(int.Parse).ToList();
        }

        public int GetDifferenceOfMinAndMaxValue(List<int> row)
        {
            int max = GetMaximumValueFromList(row);
            int min = GetMinimumValueFromList(row);
            return max - min;
        }
        public int GetMinimumValueFromList(List<int> row)
        {
            return row.Min();
        }

        public int GetMaximumValueFromList(List<int> row)
        {
            return row.Max();
        }
    }
}
