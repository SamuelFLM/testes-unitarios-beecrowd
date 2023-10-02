using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests05
    {
        [Theory]
        [InlineData(new double[] {5.0, 7.1}, "MEDIA = 6,43182")]
        [InlineData(new double[] {0.0, 7.1}, "MEDIA = 4,84091")]
        [InlineData(new double[] {10.0, 10.0}, "MEDIA = 10,00000")]
        public void Test1(double[] num, string resultadoEsperado)
        {
            double mediaNotaAluno = ((num[0] * 3.5) + (num[1] * 7.5)) / 11;
            string resultado = $"MEDIA = {mediaNotaAluno:F5}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}