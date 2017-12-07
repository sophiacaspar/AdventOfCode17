using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/**
 * The first row's largest and smallest values are 9 and 1, and their difference is 8.
 * The second row's largest and smallest values are 7 and 3, and their difference is 4.
 * The third row's difference is 6.
 * In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.
 * 
 * */

namespace AdventOfCode17.Day2.Tests
{
    [TestClass]
    public class CheckSumTests
    {
        private Checksum _checksum;
        private List<int> _intTestList;
        private List<string> _stringTestList;

        [TestInitialize]
        public void SetUp()
        {
            _checksum = new Checksum();
            _intTestList = new List<int>(new int[] { 5, 1, 9, 5 });
            _stringTestList = new List<string>();
            _stringTestList.Add("5 1 9 5");
            _stringTestList.Add("7 5 3");
            _stringTestList.Add("2 4 6 8");
        }


        [TestMethod]
        public void Should_get_minimum_value_from_list()
        {
            int minFromList = _checksum.GetMinimumValueFromList(_intTestList);
            Assert.AreEqual(1, minFromList);
        }

        [TestMethod]
        public void Should_get_maximum_value_from_list()
        {
            int maxFromList = _checksum.GetMaximumValueFromList(_intTestList);
            Assert.AreEqual(9, maxFromList);
        }

        [TestMethod]
        public void Should_get_the_difference_of_min_and_max_values()
        {
            int difference = _checksum.GetDifferenceOfMinAndMaxValue(_intTestList);
            Assert.AreEqual(8, difference);
        }

        [TestMethod]
        public void Should_get_the_checksum_of_all_differences()
        {
            int checksum = _checksum.CalculateChecksum(_stringTestList);
            Assert.AreEqual(18, checksum);
        }
    }
}
