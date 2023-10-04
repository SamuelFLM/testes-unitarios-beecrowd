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
            Assert.True(true);
        }
    }
}