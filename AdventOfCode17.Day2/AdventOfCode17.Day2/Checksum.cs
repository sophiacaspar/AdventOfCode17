using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode17.Day2
{
    public class Checksum
    {
        private List<int> _differences;
        private List<int> _divisibles;

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

        public int CalculateDivisibleChecksum(List<string> rows)
        {
            _divisibles = new List<int>();
            foreach (string row in rows)
            {
                var values = ConvertStringListToIntList(row);
                _divisibles.Add(GetDivisions(values));
            }
            return _divisibles.Sum();
        }

        public List<int> ConvertStringListToIntList(string row)
        {
            var test = row.Split().Select(int.Parse).ToArray();
            return row.Split().Select(int.Parse).ToList();
        }

        public int GetDivisions(List<int> row)
        {
            for (int i = 0; i < row.Count; i++)
            {
                for (int j = 0; j < row.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (row[i] % row[j] == 0)
                    {
                        return row[i] / row[j];
                    }
                }
            }
            return 0;
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
