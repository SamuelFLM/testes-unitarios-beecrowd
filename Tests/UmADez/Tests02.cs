using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests02
    {
        [Theory]
        [InlineData(2.00, "A=12,5664")]
        [InlineData(100.64, "A=31819,3103")]
        [InlineData(150.00, "A=70685,7750")]
        public void CalculaAreaDoCirculo(double raio, string resultadoEsperado)
        {
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            string resultado = $"A={area:F4}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}