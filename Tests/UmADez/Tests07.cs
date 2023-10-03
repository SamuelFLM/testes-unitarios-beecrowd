using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests07
    {
        [Theory]
        [InlineData(new int[] { 5, 6, 7, 8 }, "DIFERENCA = -26")]
        [InlineData(new int[] { 0, 0, 7, 8 }, "DIFERENCA = -56")]
        [InlineData(new int[] { 5, 6, -7, 8 }, "DIFERENCA = 86")]
        public void DeveFuncionarCorretamente(int[] nums, string resultadoEsperado)
        {
            int diferenca = (nums[0] * nums[1]) - (nums[2] * nums[3]);
            string resultado = $"DIFERENCA = {diferenca}";
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new int[] { 5, 6, 7, 8 }, "DIFERENCA = -26")]
        public void DeveFalharERetornarFalseNaComparacaoDeResultado(int[] nums, string resultadoEsperado)
        {
            int diferenca = (nums[0] * nums[1]) - (nums[2] * nums[3]);
            string resultado = $"DIFERENCA= {diferenca}";
            Assert.False(resultadoEsperado == resultado);
        }
    }
}