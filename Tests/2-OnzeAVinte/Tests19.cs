using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests19
    {
        [Theory]
        [InlineData(556, "0:9:16")]
        [InlineData(1, "0:0:1")]
        [InlineData(140153, "38:55:53")]
        public void Test1(int num, string resultado)
        {
            Assert.Equal(resultado, $"{num / 3600}:{num % 3600 / 60}:{num % 3600 % 60}");
        }
    }
}