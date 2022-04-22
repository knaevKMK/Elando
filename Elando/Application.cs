namespace Elando
{
    using Generator;
    using IO;

    public class Application
    {
        private readonly AppConsole console;
        private readonly PrimeNumbersGenerator primeNumbersGenerator;
        private readonly MultiplicationTableGenerator multiplicationTabelGenerator;

        public Application()
        {
            this.console = new AppConsole();
            this.primeNumbersGenerator = new PrimeNumbersGenerator();
            this.multiplicationTabelGenerator = new MultiplicationTableGenerator();
        }

        public void Run()
        {
            int n = console.ReadNum();

            var primeNUmbers = primeNumbersGenerator.Generate(n);
            var matrix = multiplicationTabelGenerator.Generate(primeNUmbers);

            AppConsole.PrintMatrix(matrix);
        }
    }
}
