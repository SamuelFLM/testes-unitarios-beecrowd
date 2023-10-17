using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Vinte1ATrinta
{
    public class Tests22
    {
        // [InlineData(new double[] { 0.0, 20.0, 5.0 }, new string[] { "Impossivel calcular" })]
        [Theory]
        [InlineData(new double[] { 10.0, 20.1, 5.1 }, new string[] { "R1 = 0,29788", "R2 = 1,71212" })]
        [InlineData(new double[] { 10.3, 203.0, 5.0 }, new string[] { "R1 = 0,02466", "R2 = 19,68408" })]
        public void Test1(double[] nums, string[] resultadoEsperado)
        {

            double delta = Math.Pow(nums[1], 2) + (4 * nums[0] * ( - nums[2]));


            double r1 = Math.Abs((-nums[1] + Math.Sqrt(delta)) / (2 * nums[0]));
            double r2 = Math.Abs((-nums[1] - Math.Sqrt(delta)) / (2 * nums[0]));

            Assert.Equal(resultadoEsperado[0], $"R1 = {r1:F5}");
            Assert.Equal(resultadoEsperado[1], $"R2 = {r2:F5}");

        }
    }
}