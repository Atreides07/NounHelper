using System;
using Xunit;

namespace NounHelper.Test
{
    public class NounTest
    {
        [Theory]
        [InlineData(0, "����������")]
        [InlineData(1, "��������")]
        [InlineData(2, "���������")]
        [InlineData(3, "���������")]
        [InlineData(4, "���������")]
        [InlineData(5, "����������")]
        [InlineData(6, "����������")]
        [InlineData(7, "����������")]
        [InlineData(8, "����������")]
        [InlineData(9, "����������")]
        [InlineData(10, "����������")]
        [InlineData(11, "����������")]
        [InlineData(12, "����������")]
        [InlineData(13, "����������")]
        [InlineData(14, "����������")]
        [InlineData(15, "����������")]
        [InlineData(16, "����������")]
        [InlineData(17, "����������")]
        [InlineData(19, "����������")]
        [InlineData(20, "����������")]
        [InlineData(21, "��������")]
        [InlineData(55,  "����������")]
        [InlineData(101, "��������")]
        [InlineData(111, "����������")]
        [InlineData(112, "����������")]
        public void TestNoun(int number, string expected)
        {
            var f0 = "����������";
            var f1 = "��������";
            var f2 = "���������";

            var actual = Noun.GetDeclension(number, f1, f2, f0);
            Assert.Equal(expected, actual);
        }
    }
}
