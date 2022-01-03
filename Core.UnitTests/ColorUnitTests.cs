using TodoListExample.Core.ValueObjects;
using Xunit;
using System;
using System.Linq;
using TodoListExample.Core.Exceptions;

namespace Core.UnitTests
{
    public class ColorUnitTests
    {
        [Fact]
        public void ColorConstructor_UnsupportedIntCode_ThrowsUnsupportedColorCodeException()
        {
            // this color code can't be supported in any circumstance, because it is more than 16^6
            const int unsupportedColorCode = int.MaxValue; 

            Assert.Throws<UnsupportedColorCodeException>(() =>
            {
                var _ = new Color(unsupportedColorCode);
            });
        }

        [Fact]
        public void SupportedColors_IsNotEmpty()
        {
            Assert.NotEmpty(Color.SupportedColors());
        }
        
        [Fact]
        public void ColorCodeString_ReturnsCorrectColorFormat()
        {
            foreach (var color in Color.SupportedColors())
            {
                // starts with # character
                // contains exactly 6 hexadecimal digits after # and before end of the string

                Assert.Matches("^#([a-fA-F0-9]{6})$", color.CodeString);
            }
        }

        [Fact]
        public void ColorCodeInt_ReturnsCorrectColorCodeValue()
        {
            // if there are 6 hexadecimal numbers, then maximum possible number is 16 pow 6 - 1
            var maxColorNum = (int) Math.Pow(16, 6) - 1;
            var minColorNum = 0;

            foreach (var color in Color.SupportedColors())
            {
                var actual = color.CodeInt;
                Assert.True(minColorNum <= actual && actual <= maxColorNum);
            }
        }

        private static bool IsWordCapitalized(string word)
        { 
            var firstLetterIsUppercase = char.IsUpper(word[0]);
            var notFirstLettersAreLowercase = word[1..].All(char.IsLower);

            return firstLetterIsUppercase && notFirstLettersAreLowercase;
        }

        private static bool AllWordsAreCapitalized(string str)
        {
            return str.Split(' ').All(IsWordCapitalized);
        }

        [Fact]
        public void ColorName_AllWordsAreCapitalized()
        {
            foreach (var color in Color.SupportedColors())
            {
                var words = color.Name.Split(' ');

                // does not contain not capitalized word
                Assert.DoesNotContain(words, word => !IsWordCapitalized(word));
            }
        }

        [Fact]
        public void ColorName_IsTrimmed()
        {
            foreach (var color in Color.SupportedColors())
            {
                Assert.Equal(color.Name.Length, color.Name.Trim().Length);
            }
        }

        [Fact]
        public void ColorName_HasNoRepeatingSpaces()
        {
            foreach (var color in Color.SupportedColors())
            {
                var words = color.Name.Split(' ');
                Assert.DoesNotContain(words, word => word.Length == 0);
            }
        }

    }
}