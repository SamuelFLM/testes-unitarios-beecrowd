using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests15
    {
        [Theory]
        [InlineData(new double[] { 1.0, 7.0, 5.0, 9.0 }, "4,4721")]
        [InlineData(new double[] { -2.5, 0.4, 12.1, 7.3 }, "16,1484")]
        [InlineData(new double[] { 2.5, -0.4, -12.2, 7.0 }, "16,4575")]
        public void Test1(double[] num, string resultadoEsperado)
        {
            double calculo = Math.Sqrt(Math.Pow(num[2] - num[0], 2) + Math.Pow(num[3] - num[1], 2));
            Assert.Equal(resultadoEsperado, calculo.ToString("F4"));
        }
    }
}