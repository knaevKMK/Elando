namespace Elando.Test
{
    using System;

    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneratorPrimeTest
    {
        private readonly PrimeNumbersGenerator primeNumbersGenerator = new();

        [TestMethod]
        [DataRow(3, new long[] { 2, 3, 5 })]
        [DataRow(7, new long[] { 2, 3, 5, 7, 11, 13, 17 })]
        [DataRow(11, new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 })]
        public void GetPrimes_InputvalidCountOfNumbers_Return_ValidPrimeValues(int validInput, long[] checkPrimes)
        {
            var primes = primeNumbersGenerator.Generate(validInput);
            CollectionAssert.AreEqual(primes, checkPrimes);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void GetPrimes_InputValidCountOfNumbers_Return_PrimesAsArray(int validInput)
        {
            var primes = primeNumbersGenerator.Generate(validInput);
            Assert.IsInstanceOfType(primes, typeof(long[]));
            Assert.IsTrue(primes.Length == validInput);
            if (validInput == 0) { CollectionAssert.AreEqual(primes, Array.Empty<long>()); }
        }
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void GetPrimes_InputNeagtivedCountOfNumbers_Throw(int inValidInput)
        {
            Assert.ThrowsException<OverflowException>(() => primeNumbersGenerator.Generate(inValidInput));
        }
        [TestMethod]
        [DataRow("2")]
        public void GetPrimes_InputNaNCountOfNumbers_Throw(object inValidInput)
        {
            Assert.ThrowsException<InvalidCastException>(() => primeNumbersGenerator.Generate((int)inValidInput));
        }
    }
}
