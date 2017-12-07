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
        private List<int> _inputTestList;
        private List<int> _differenceTestList;

        [TestInitialize]
        public void SetUp()
        {
            _checksum = new Checksum();
            _inputTestList = new List<int>(new int[] { 5, 1, 9, 5 });
            _differenceTestList = new List<int>(new int[] { 8, 4, 6 });
        }


        [TestMethod]
        public void Should_get_minimum_value_from_list()
        {
            int minFromList = _checksum.GetMinimumValueFromList(_inputTestList);
            Assert.AreEqual(1, minFromList);
        }

        [TestMethod]
        public void Should_get_maximum_value_from_list()
        {
            int maxFromList = _checksum.GetMaximumValueFromList(_inputTestList);
            Assert.AreEqual(9, maxFromList);
        }

        [TestMethod]
        public void Should_get_the_difference_of_min_and_max_values()
        {
            int difference = _checksum.GetDifferenceOfMinAndMaxValue(_inputTestList);
            Assert.AreEqual(8, difference);
        }

        [TestMethod]
        public void Should_get_the_checksum_of_all_differences()
        {
            int checksum = _checksum.CalculateChecksum(_differenceTestList);
            Assert.AreEqual(18, checksum);
        }
    }
}
