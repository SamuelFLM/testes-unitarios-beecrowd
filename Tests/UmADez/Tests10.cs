using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests10
    {
        [Theory]
        [InlineData(new double[] { 12, 1, 5.30 }, new double[] { 16, 2, 5.10 }, "VALOR A PAGAR: R$ 15,50")]
        [InlineData(new double[] { 13, 2, 15.30 }, new double[] { 161, 4, 5.20 }, "VALOR A PAGAR: R$ 51,40")]
        [InlineData(new double[] { 1, 1, 15.10 }, new double[] { 2, 1, 15.10 }, "VALOR A PAGAR: R$ 30,20")]
        public void Sucesso(double[] num1, double[] num2, string resultadoEsperado)
        {
            double calculo = (num1[1] * num1[2]) + (num2[1] * num2[2]);
            string resultado = $"VALOR A PAGAR: {calculo:C2}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}