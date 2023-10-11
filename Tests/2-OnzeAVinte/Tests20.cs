using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests20
    {
        [Theory]
        [InlineData(400, new string[] {"1 ano (s)" , "1 mes (es)", "5 dia (s)"})]
        [InlineData(800, new string[] {"2 ano (s)" , "2 mes (es)", "10 dia (s)"})]
        [InlineData(30, new string[] {"0 ano (s)" , "1 mes (es)", "0 dia (s)"})]
        public void Test1(int dia, string[] resultadoEsperado)
        {

            Assert.Equal(resultadoEsperado[0], $"{dia / 365} ano (s)");
            Assert.Equal(resultadoEsperado[1], $"{dia % 365 / 30} mes (es)");
            Assert.Equal(resultadoEsperado[2], $"{dia % 365 % 30} dia (s)");
        }
    }
}