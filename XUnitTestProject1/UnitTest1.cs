using System;
using Xunit;
using Hanoi;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Recur2p5()
        {
            Assert.Equal(2 * 2 * 2 * 2 * 2, Program.Power(2, 5));
        }

        [Fact]
        public void Recur4p4()
        {
            Assert.Equal(4 * 4 * 4 * 4, Program.Power(4, 4));
        }

        [Fact]
        public void RecurI2p5()
        {
            Assert.Equal(2 * 2 * 2 * 2 * 2, Program.PowerI(2, 5));
        }

        [Fact]
        public void RecurI4p4()
        {
            Assert.Equal(4 * 4 * 4 * 4, Program.PowerI(4, 4));
        }

        [Fact]
        public void Hanoi4()
        {
            Assert.Equal(15, Program.Hanoi(4));
        }

        [Fact]
        public void HanoiI4()
        {
            Assert.Equal(15, Program.HanoiI(4));
        }
    }
}
