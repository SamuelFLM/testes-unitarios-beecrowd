using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UmADez
{
    public class Tests01
    {
        [Theory]
        [InlineData(new int[] {10,9})]
        [InlineData(new int[] {-10, 4})]
        [InlineData(new int[] {15, -7})]
        public void CalculaASomaDeDoisValores(int[] num)
        {
            int soma = num.Sum();
            string resultado = $"X = {soma}";
            Assert.Equal($"X = {soma}", resultado);
        }
    }
}