using PalindromeExercise;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("test", false)]
        public void TestIsAPalindrome(string input, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
