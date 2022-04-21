namespace Elando.Test
{
    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneratorPrimeTest
    {
        private readonly PrimeNumbersGenerator primeNumbersGenerator = new();

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void GetPrimes_InputValidCountOfNumbers_Return_Primes_As_Array(int validInput)
        {
            var primes = primeNumbersGenerator.Generate(validInput);
            Assert.IsInstanceOfType(primes, typeof(long[]));

        }
    }
   
}
