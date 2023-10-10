using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.OnzeAVinte
{
    public class Tests18
    {
        [Theory]
        [InlineData(576, new string[]{
            "5 nota(s) de R$ 100,00",
            "1 nota(s) de R$ 50,00",
            "1 nota(s) de R$ 20,00",
            "0 nota(s) de R$ 10,00",
            "1 nota(s) de R$ 5,00",
            "0 nota(s) de R$ 2,00",
            "1 nota(s) de R$ 1,00",
        })]
        public void Test1(int num, string[] resultados)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < notas.Length; i++)
            {
                Assert.Equal(resultados[i], $"{num / notas[i]} nota(s) de {notas[i]:C}");
                num %= notas[i];
            }
        }
        [Theory]
        [InlineData(11257, new string[]{
            "112 nota(s) de R$ 100,00",
            "1 nota(s) de R$ 50,00",
            "0 nota(s) de R$ 20,00",
            "0 nota(s) de R$ 10,00",
            "1 nota(s) de R$ 5,00",
            "1 nota(s) de R$ 2,00",
            "0 nota(s) de R$ 1,00",
        })]
        public void Test2(int num, string[] resultados)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < notas.Length; i++)
            {
                Assert.Equal(resultados[i], $"{num / notas[i]} nota(s) de {notas[i]:C}");
                num %= notas[i];
            }
        }

    }
}