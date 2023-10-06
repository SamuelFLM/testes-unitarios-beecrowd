using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests14
    {
        [Theory]
        [InlineData(new double[] {500,35.0}, "14,286 km/l")]
        [InlineData(new double[] {2254,124.4}, "18,119 km/l")]
        [InlineData(new double[] {4554,464.6}, "9,802 km/l")]
        public void Test1(double[] num, string resultadoEsperado)
        {
            double calculo = num[0] / num[1];
            Assert.Equal(resultadoEsperado, $"{calculo:F3} km/l");
        }
    }
}