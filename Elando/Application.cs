namespace Elando
{
    using Generator;
    using IO;

    public class Application
    {
        private readonly AppConsole console;

        public Application()
        {
            this.console = new AppConsole();
        }

        public void Run()
        {
            int n = console.ReadNum();

            var primeNUmbers = NumbersGenerator.GeneratePrimes(n);
            MultiplicationTableGenerator.Generate(primeNUmbers);
        }
    }
}
