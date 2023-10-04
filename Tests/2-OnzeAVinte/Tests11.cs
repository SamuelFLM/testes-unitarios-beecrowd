using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests11
    {
        [Theory]
        [InlineData(3, "VOLUME = 113,097")]
        [InlineData(15, "VOLUME = 14137,155")]
        [InlineData(1523, "VOLUME = 14797486501,627")]
        public void Test1(int num, string resultadoEsperado)
        {
            double calculo = (4.0 / 3) * 3.14159 * Math.Pow(num, 3);
            string resultado = $"VOLUME = {calculo:F3}";
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}