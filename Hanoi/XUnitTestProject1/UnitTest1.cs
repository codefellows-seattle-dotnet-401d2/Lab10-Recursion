using System;
using Xunit;
using Hanoi;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(15, Program.RecursiveHanoi(4));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(255, Program.RecursiveHanoi(8));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(1023, Program.RecursiveHanoi(10));
        }

        [Theory]
        [InlineData (15, 4)]
        [InlineData (63, 6)]
        public void Test4(int answer, int n)
        {
            Assert.Equal(answer, Program.RecursiveHanoi(n));
        }


    }

}
