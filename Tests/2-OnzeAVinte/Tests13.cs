using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests13
    {
        [Theory]
        [InlineData(new int[] { 7, 14, 106 }, "106 eh o maior")]
        [InlineData(new int[] { 217, 14, 6 }, "217 eh o maior")]
        public void Sucesso(int[] num, string resultadoEsperado)
        {
            string resultado = $"{num.Max()} eh o maior";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}