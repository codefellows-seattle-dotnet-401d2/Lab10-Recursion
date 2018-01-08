using System;
using Xunit;
using TowersOfHanoi;

namespace XUnitTestHanoi
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (3, 7)]
        [InlineData (4, 15)]
        [InlineData (5, 31)]
        [InlineData (6, 63)]
        [InlineData (7, 127)]
        public void Test1(int n, int answer)
        {
            Assert.Equal(answer, Program.Hanoi(n));
        }
    }
}
