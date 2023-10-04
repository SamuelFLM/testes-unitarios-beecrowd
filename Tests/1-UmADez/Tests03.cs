using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests03
    {
        [Theory]
        [InlineData(new int[] { 30, 10 }, "SOMA = 40")]
        [InlineData(new int[] { -30, 10 }, "SOMA = -20")]
        [InlineData(new int[] { 0, 0 }, "SOMA = 0")]
        public void SomaSimples(int[] num, string resultadoEsperado)
        {
            int soma = num.Sum();
            string resultado = $"SOMA = {soma}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}