namespace Elando.Test
{
    using System;
    using System.IO;

    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static Out.OutResult;
    [TestClass]
    public class GeneratorMultiplicationTableTest
    {
        [TestMethod]
        [DataRow(new long[] { 0, 0 }, "result1")]
        [DataRow(new long[] { -2, 5, 0 }, "result2")]
        [DataRow(new long[] { 2, 3, 5, 7 }, "result3")]
        public void Generate_InputValidNumbers_Return_ValidResult(long[] input, string result)
        {

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MultiplicationTableGenerator.Generate(input);

            var printResult = stringWriter.ToString();
            Assert.AreEqual(GetResult(result), printResult);
        }

        [TestMethod]
        public void Generate_InputEmptyPrimes_Return_EmptyMatrix()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MultiplicationTableGenerator.Generate(Array.Empty<long>());

            string printResult = stringWriter.ToString();
            Assert.AreEqual(GetResult("empty"), printResult);
        }

       
    }
}
