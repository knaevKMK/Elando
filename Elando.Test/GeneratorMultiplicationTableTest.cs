namespace Elando.Test
{
    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class GeneratorMultiplicationTableTest
    {
        private readonly PrimeNumbersGenerator primeNumbersGenerator = new();
        private readonly MultiplicationTableGenerator multiplicationTabelGenerator = new();

        private readonly long[] primeResult2 = { 2, 3 };
        private readonly long[] primeResult3 = { 2, 3, 5 };
        private readonly long[] primeResult4 = { 2, 3, 5, 7 };

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void GetPrimes_InputValidCountOfNumbers_Return_Primes_As_Array(int validInput)
        {
            var primes = primeNumbersGenerator.Generate(validInput);
            var result = multiplicationTabelGenerator.Generate(primes);
            Assert.IsInstanceOfType(result, typeof(long[,]));

        }
    }
}
