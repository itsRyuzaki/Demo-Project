using System;
using Xunit;
using FirstLib;

namespace test_library
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ob = new Addition();
            Assert.Equal(21, ob.sum(12, 9));

        }
    }
}
