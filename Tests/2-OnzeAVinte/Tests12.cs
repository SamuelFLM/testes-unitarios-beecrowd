using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests12
    {
        [Theory]
        [InlineData(new double[] { 3.0, 4.0, 5.2 }, new string[] {
            "TRIANGULO: 7,800",
            "CIRCULO: 84,949",
            "TRAPEZIO: 18,200",
            "QUADRADO: 16,000",
            "RETANGULO: 12,000",
        })]
        public void Test1(double[] num, string[] resultados)
        {
            double calculoTriangulo = num[0] * num[2] / 2;
            double calculoCirculo = 3.14159 * Math.Pow(num[2], 2);
            double calculoTrapezio = ((num[0] + num[1]) * num[2]) / 2;
            double calculoQuadrado = Math.Pow(num[1], 2);
            double calculoRetangulo = num[0] * num[1];

            Assert.Equal(resultados[0], $"TRIANGULO: {calculoTriangulo:F3}");
            Assert.Equal(resultados[1], $"CIRCULO: {calculoCirculo:F3}");
            Assert.Equal(resultados[2], $"TRAPEZIO: {calculoTrapezio:F3}");
            Assert.Equal(resultados[3], $"QUADRADO: {calculoQuadrado:F3}");
            Assert.Equal(resultados[4], $"RETANGULO: {calculoRetangulo:F3}");

        }
    }
}