using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests06
    {
        [Theory]
        [InlineData(new double[] { 5.0, 6.0, 7.0 }, "MEDIA = 6,3")]
        [InlineData(new double[] { 5.0, 10.0, 10.0 }, "MEDIA = 9,0")]
        [InlineData(new double[] { 10.0, 10.0, 5.0 }, "MEDIA = 7,5")]
        public void Test1(double[] num, string resultadoEsperado)
        {
            double mediaNotaAluno = ((num[0] * 2) + (num[1] * 3) + (num[2] * 5)) / 10;
            string resultado = $"MEDIA = {mediaNotaAluno:F1}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}