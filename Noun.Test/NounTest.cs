using System;
using Xunit;

namespace NounHelper.Test
{
    public class NounTest
    {
        [Theory]
        [InlineData(0, "источников")]
        [InlineData(1, "источник")]
        [InlineData(2, "источника")]
        [InlineData(3, "источника")]
        [InlineData(4, "источника")]
        [InlineData(5, "источников")]
        [InlineData(6, "источников")]
        [InlineData(7, "источников")]
        [InlineData(8, "источников")]
        [InlineData(9, "источников")]
        [InlineData(10, "источников")]
        [InlineData(11, "источников")]
        [InlineData(12, "источников")]
        [InlineData(13, "источников")]
        [InlineData(14, "источников")]
        [InlineData(15, "источников")]
        [InlineData(16, "источников")]
        [InlineData(17, "источников")]
        [InlineData(19, "источников")]
        [InlineData(20, "источников")]
        [InlineData(21, "источник")]
        [InlineData(55,  "источников")]
        [InlineData(101, "источник")]
        [InlineData(111, "источников")]
        [InlineData(112, "источников")]
        public void TestNoun(int number, string expected)
        {
            var f0 = "источников";
            var f1 = "источник";
            var f2 = "источника";

            var actual = Noun.NounHelper.GetDeclension(number, f1, f2, f0);
            Assert.Equal(expected, actual);
        }
    }
}
