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

        private static string GetResult(string result)
        {
            switch (result)
            {
                case "result1": return $"┌───┬───┬───┐{Environment.NewLine}│   │ 0 │ 0 │{Environment.NewLine}├───┼───┼───┤{Environment.NewLine}│ 0 │ 0 │ 0 │{ Environment.NewLine}├───┼───┼───┤{Environment.NewLine}│ 0 │ 0 │ 0 │{Environment.NewLine }└───┴───┴───┘{Environment.NewLine}{Environment.NewLine}";
                case "result2": return $"┌────┬─────┬─────┬───┐{Environment.NewLine}│    │ -2  │ 5   │ 0 │{Environment.NewLine}├────┼─────┼─────┼───┤{Environment.NewLine}│ -2 │ 4   │ -10 │ 0 │{ Environment.NewLine}├────┼─────┼─────┼───┤{Environment.NewLine}│ 5  │ -10 │ 25  │ 0 │{Environment.NewLine }├────┼─────┼─────┼───┤{Environment.NewLine}│ 0  │ 0   │ 0   │ 0 │{Environment.NewLine }└────┴─────┴─────┴───┘{Environment.NewLine}{Environment.NewLine}";
                case "result3": return $"┌───┬────┬────┬────┬────┐{Environment.NewLine}│   │ 2  │ 3  │ 5  │ 7  │{Environment.NewLine}├───┼────┼────┼────┼────┤{Environment.NewLine}│ 2 │ 4  │ 6  │ 10 │ 14 │{ Environment.NewLine}├───┼────┼────┼────┼────┤{Environment.NewLine}│ 3 │ 6  │ 9  │ 15 │ 21 │{Environment.NewLine }├───┼────┼────┼────┼────┤{Environment.NewLine}│ 5 │ 10 │ 15 │ 25 │ 35 │{Environment.NewLine}├───┼────┼────┼────┼────┤{Environment.NewLine}│ 7 │ 14 │ 21 │ 35 │ 49 │{Environment.NewLine}└───┴────┴────┴────┴────┘{Environment.NewLine}{Environment.NewLine}";
                default: return $"┌──┐{Environment.NewLine}│  │{Environment.NewLine}└──┘{Environment.NewLine}{Environment.NewLine}";
            }
        }
    }
}
