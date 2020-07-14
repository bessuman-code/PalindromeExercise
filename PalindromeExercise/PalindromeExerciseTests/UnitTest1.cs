using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        public void Test1(string inputWord, bool expected)
        {
            //Arrange
            var wordsmith = new WordSmith();

            //Act
            var actual = wordsmith.IsAPalindrome(inputWord);

            //Assert
            Assert.Equal(expected, actual);
            
        }


    }
}
