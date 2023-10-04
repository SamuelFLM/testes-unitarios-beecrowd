using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests08
    {
        [Theory]
        [InlineData(new double[] { 25, 100, 5.50 }, new string[] { "NUMBER = 25", "SALARY = U$ 550,00" })]
        [InlineData(new double[] { 1, 200, 20.50 }, new string[] { "NUMBER = 1", "SALARY = U$ 4100,00" })]
        [InlineData(new double[] { 6, 145, 15.55 }, new string[] { "NUMBER = 6", "SALARY = U$ 2254,75" })]
        public void Sucesso(double[] nums, string[] resultadoEsperado)
        {
            double salario = nums[1] * nums[2];
            Assert.Equal(resultadoEsperado[0], $"NUMBER = {nums[0]}");
            Assert.Equal(resultadoEsperado[1], $"SALARY = U$ {salario:F2}");
        }

        [Theory]
        [InlineData(new double[] { 25, 100, 5.50 }, new string[] { "NUMBER = 25", "SALARY = U$ 550,00" })]
        [InlineData(new double[] { 1, 200, 20.50 }, new string[] { "NUMBER = 1", "SALARY = U$ 4100,00" })]
        [InlineData(new double[] { 6, 145, 15.55 }, new string[] { "NUMBER = 6", "SALARY = U$ 2254,75" })]
        public void Falha(double[] nums, string[] resultadoEsperado)
        {
            double salario = nums[1] * nums[2] + 1;
            
            Assert.False(resultadoEsperado[0] == "NUMBER =1");
            Assert.False(resultadoEsperado[1] == "SALARY=");
            Assert.False(resultadoEsperado[1] == "salary=");
            Assert.NotEmpty(resultadoEsperado);

        }
    }
}