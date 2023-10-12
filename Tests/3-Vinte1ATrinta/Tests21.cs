using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Vinte1ATrinta
{
    public class Tests21
    {
        [Theory]
        [InlineData("576,73", new string[]{
            "5 nota(s) de R$ 100,00",
            "1 nota(s) de R$ 50,00",
            "1 nota(s) de R$ 20,00",
            "0 nota(s) de R$ 10,00",
            "1 nota(s) de R$ 5,00",
            "0 nota(s) de R$ 2,00",
            },
            new string[]{
            "1 moeda(s) de R$ 1,00",
            "1 moeda(s) de R$ 0,50",
            "0 moeda(s) de R$ 0,25",
            "0 moeda(s) de R$ 0,10",
            "0 moeda(s) de R$ 0,05",
            "0 moeda(s) de R$ 0,01",
            }
        )]
        public void Test1(string num, string[] resultadoNotas, string[] resultadoMoedas)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2 };

            double[] moedas = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

            string[] separator = num.Split(",");

            int nota = Convert.ToInt32(separator[0]);

            double moeda = Convert.ToDouble(separator[1]);

            for (int i = 0; i < notas.Length; i++)
            {
                Assert.Equal(resultadoNotas[i], $"{nota / notas[i]} nota(s) de {notas[i]:C2}");
                nota %= notas[i];
            }

            int restoNota = nota;
            Assert.Equal(resultadoMoedas[0], $"{restoNota / moedas[0]} moeda(s) de {moedas[0]:C2}");

            for (int i = 1; i < moedas.Length; i++)
            {
                Assert.Equal(resultadoMoedas[i], $"{moeda / 100 / moedas[i]:F0} moeda(s) de {moedas[i]:C2}");
                moeda %= moedas[i];
            }

        }
    }
}