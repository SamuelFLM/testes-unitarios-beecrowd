using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests16
    {
        [Theory]
        [InlineData(30, "60 minutos")]
        [InlineData(110, "220 minutos")]
        [InlineData(7, "14 minutos")]
        public void Test1(int km, string resultadoEsperado)
        {
            int calculo = km * 2;
            Assert.Equal(resultadoEsperado, $"{calculo} minutos");
        }
    }
}