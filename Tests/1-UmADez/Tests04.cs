using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests04
    {
        [Theory]
        [InlineData(new int[] { 3, 9 }, "PROD = 27")]
        [InlineData(new int[] { -30, 10 }, "PROD = -300")]
        [InlineData(new int[] { 0, 9 }, "PROD = 0")]
        public void Test1(int[] num, string resultadoEsperado)
        {
            int prod = num[0] * num[1];
            string resultado = $"PROD = {prod}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}