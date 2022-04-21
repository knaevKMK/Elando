namespace IO
{
    public class AppConsole
    {
        public static void Print(long[,] args)
        {
            var lenght = Math.Sqrt(args.Length);
            Console.Write("\t");
            for (int col = 1; col < lenght; col++)
            {
                Console.Write($"{args[0, col]}\t");
            }
            Console.WriteLine();
            for (int row = 1; row < lenght; row++)
            {
                for (int col = 0; col < lenght; col++)
                {
                    Console.Write($"{args[row, col]}\t");
                }
                Console.WriteLine();
            }
        }

        private int num;
        public int Read()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input.Trim(), out num) || num <= 0)
            {
                Console.WriteLine("Please enter valid positive number");
                Read();
            }

            return num;
        }
    }
}