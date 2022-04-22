namespace Elando.Test
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [DataRow("2", "Insert valid positive number: \nResult is:\n\n\t2\t3\t\n2\t4\t6\t\n3\t6\t9\t\n")]
        [DataRow("3", "Insert valid positive number: \nResult is:\n\n\t2\t3\t5\t\n2\t4\t6\t10\t\n3\t6\t9\t15\t\n5\t10\t15\t25\t\n")]
        public void Read_ValidInput_WriteResult(string input, string result)
        {
            Console.SetIn(new StringReader(input));
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            app.Run();
            var printResult = stringWriter.ToString();
            Assert.AreEqual(result, printResult);
        }
    }
}
