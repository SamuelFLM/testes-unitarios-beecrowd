using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests17
    {
        [Theory]
        [InlineData(new int[] { 10, 85 }, "70,833")]
        [InlineData(new int[] { 2, 92 }, "15,333")]
        [InlineData(new int[] { 22, 67 }, "122,833")]
        public void Test1(int[] nums, string resultadoEsperado)
        {

            double calculo = (double)nums[0] * nums[1] / 12;
            Assert.Equal(resultadoEsperado, $"{calculo:F3}");
        }
    }
}