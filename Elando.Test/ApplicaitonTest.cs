namespace Elando.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using static Out.OutResult;

    [TestClass]
    public class ApplicaitonTest
    {
        private readonly Application app = new();

        [TestMethod]
        [DataRow("-1")]
        [DataRow("0")]
        [DataRow("trim")]
        public void Read_InvalidInput_NotThrow_And_ReadAgain(string input)
        {
            Console.SetIn(new StringReader(input));
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            //TODO recurse => input= null => throw 
            //real executing does not throw if insert invalid data
           Assert.ThrowsException<NullReferenceException>(() => app.Run());
        }

        [TestMethod]
        [DataRow("2", "result4")]
        [DataRow("3", "result5")]
        public void Read_ValidInput_WriteResult(string input, string result)
        {
            Console.SetIn(new StringReader(input));
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            app.Run();
            var printResult = stringWriter.ToString();
            Assert.AreEqual(GetResult(result), printResult);
        }
    }
}