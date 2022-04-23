namespace Elando.Test
{
    using System;
    using System.IO;

    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneratorMultiplicationTableTest
    {
        [TestMethod]
        [DataRow(new long[] { 0, 0 }, "\nResult is:\n\n\t0\t0\t\n0\t0\t0\t\n0\t0\t0\t\n")]
        [DataRow(new long[] { -2, 5,0 }, "\nResult is:\n\n\t-2\t5\t0\t\n-2\t4\t-10\t0\t\n5\t-10\t25\t0\t\n0\t0\t0\t0\t\n")]
        [DataRow(new long[] { 2, 3, 5, 7 }, "\nResult is:\n\n\t2\t3\t5\t7\t\n2\t4\t6\t10\t14\t\n3\t6\t9\t15\t21\t\n5\t10\t15\t25\t35\t\n7\t14\t21\t35\t49\t\n")]
        public void Generate_InputValidNumbers_Return_ValidResult(long[] input, string expectedResult)
        {

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MultiplicationTableGenerator.Generate(input);

            var printResult = stringWriter.ToString();
            Assert.AreEqual(expectedResult, printResult);
        }

        [TestMethod]
        public void Generate_InputEmptyPrimes_Return_EmptyMatrix()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            MultiplicationTableGenerator.Generate(Array.Empty<long>());
            string expectedResult = "\nResult is:\n\n\t\n";
            string printResult = stringWriter.ToString();
            Assert.AreEqual(expectedResult, printResult);
        }
    }
}
