using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests09
    {
        [Theory]
        [InlineData("JOAO", new double[] { 500.00, 1230.30 }, "TOTAL = R$ 684,54")]
        [InlineData("PEDRO", new double[] { 700.00, 0.00 }, "TOTAL = R$ 700,00")]
        [InlineData("MANGOJATA", new double[] { 1700.00, 1230.50 }, "TOTAL = R$ 1.884,58")]
        public void Sucesso(double[] nums, string resultadoEsperado)
        {
            double calculo = (nums[1] * 0.15) + nums[0];
            string resultado = $"TOTAL = {calculo:C2}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}