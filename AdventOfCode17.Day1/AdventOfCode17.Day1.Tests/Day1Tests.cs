using Microsoft.VisualStudio.TestTools.UnitTesting;

/**
 * PART 1
 * 1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.
 * 1111 produces 4 because each digit (all 1) matches the next.
 * 1234 produces 0 because no digit matches the next.
 * 91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
 * 
 * PART 2
 * 1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
 * 1221 produces 0, because every comparison is between a 1 and a 2.
 * 123425 produces 4, because both 2s match each other, but no other digit has a match.
 * 123123 produces 12.
 * 12131415 produces 4.
 * */

namespace AdventOfCode17.Day1.Tests
{
    [TestClass]
    public class Day1Tests
    {
        private Captcha _captcha;


        [TestMethod]
        public void Should_add_two_different_digits_from_a_four_digit_sequence()
        {
            _captcha = new Captcha();
            var sequence = "1122";
            _captcha.ReviewSequence(sequence);
            int sum = _captcha.GetSum();
            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        public void Should_add_all_four_digits_from_a_four_digit_sequence()
        {
            _captcha = new Captcha();
            var sequence = "1111";
            _captcha.ReviewSequence(sequence);
            int sum = _captcha.GetSum();
            Assert.AreEqual(4, sum);

        }

        [TestMethod]
        public void Should_not_add_any_digits_from_a_four_digit_sequence()
        {
            _captcha = new Captcha();
            var sequence = "1234";
            _captcha.ReviewSequence(sequence);
            int sum = _captcha.GetSum();
            Assert.AreEqual(0, sum);

        }

        [TestMethod]
        public void Should_only_add_the_first_and_last_digits_from_a_sequence()
        {
            _captcha = new Captcha();
            var sequence = "91212129";
            _captcha.ReviewSequence(sequence);
            int sum = _captcha.GetSum();
            Assert.AreEqual(9, sum);
        }

        [TestMethod]
        public void Should_check_two_digits_ahead_and_add_the_matching_digits()
        {
            _captcha = new Captcha();
            var sequence = "1212";
            _captcha.ReviewSequenceHalfLengthAhead(sequence, sequence.Length/2);
            int sum = _captcha.GetSum();
            Assert.AreEqual(6, sum);
        }

        [TestMethod]
        public void Should_check_two_digits_ahead_and_not_add_any_digits()
        {
            _captcha = new Captcha();
            var sequence = "1221";
            _captcha.ReviewSequenceHalfLengthAhead(sequence, sequence.Length / 2);
            int sum = _captcha.GetSum();
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        public void Should_check_three_digits_ahead_and_add_the_matching_digits()
        {
            _captcha = new Captcha();
            var sequence = "123425";
            _captcha.ReviewSequenceHalfLengthAhead(sequence, sequence.Length / 2);
            int sum = _captcha.GetSum();
            Assert.AreEqual(4, sum);
        }
    }
}
