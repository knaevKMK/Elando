namespace Elando.Test
{
    using System;

    using Generator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneratorMultiplicationTableTest
    {
        private readonly MultiplicationTableGenerator multiplicationTabelGenerator = new();

        [TestMethod]
        [DataRow(new long[] { 0, 0 }, "result1")]
        [DataRow(new long[] { -2, -7 }, "result2")]
        [DataRow(new long[] { 0, -2, 5 }, "result3")]
        [DataRow(new long[] { 2, 3, 5, 7 }, "result4")]
        public void Generate_InputValidNumbers_Return_ValidResult(long[] input, string result)
        {
            var testResult = multiplicationTabelGenerator.Generate(input);
            var expectedResult = getResult(result);
            CollectionAssert.AreEqual(testResult, expectedResult);
        }

        private long[,] getResult(string result)
        {
            return result switch
            {
                "result1" => new long[,] { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } },
                "result2" => new long[,] { { 0, -2, -7 }, { -2, 4, 14 }, { -7, 14, 49 } },
                "result3" => new long[,] { { 0, 0, -2, 5 }, { 0, 0, 0, 0 }, { -2, 0, 4, -10 }, { 5, 0, -10, 25 } },
                "result4" => new long[,] { { 0, 2, 3, 5, 7 }, { 2, 4, 6, 10, 14 }, { 3, 6, 9, 15, 21 }, { 5, 10, 15, 25, 35 }, { 7, 14, 21, 35, 49 } },
                _ => new long[,] { { 0 } },
            };
        }

        [TestMethod]
        [DataRow(new long[] { 0, 0, 0 })]
        [DataRow(new long[] { -2, -3, -5, -7 })]
        [DataRow(new long[] { 1, 4, 6, 8 })]
        [DataRow(new long[] { 2, 3, 5, 7, 11, 13, 17 })]
        public void Generate_InputValidNumbers_SetValidMatrixFormat(long[] input)
        {
            var result = multiplicationTabelGenerator.Generate(input);
            Assert.IsInstanceOfType(result, typeof(long[,]));
            Assert.IsTrue(result.Length == Math.Pow((input.Length + 1), 2));
        }

        [TestMethod]
        public void Generate_InputEmptyPrimes_Return_EmptyMatrix()
        {
            var result = multiplicationTabelGenerator.Generate(Array.Empty<long>());
            Assert.IsInstanceOfType(result, typeof(long[,]));
            Assert.IsTrue(result.Length == 1);
        }
    }
}
