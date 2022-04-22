namespace Elando.Test
{
    using System;

    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneratorMultiplicationTableTest
    {
        private readonly PrimeNumbersGenerator primeNumbersGenerator = new();
        private readonly MultiplicationTableGenerator multiplicationTabelGenerator = new();

     
        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void GetPrimes_InputValidCountOfNumbers_Return_Primes_As_Array(int validInput)
        {
            var primes = primeNumbersGenerator.Generate(validInput);
            var result = multiplicationTabelGenerator.Generate(primes);
            Assert.IsInstanceOfType(result, typeof(long[,]));
            Assert.IsTrue(result.Length == Math.Pow((validInput + 1),2));
        }
    }
}
