namespace IO
{
    public class AppConsole
    {
        public static void PrintMatrix(long[,] args)
        {
            var lenght = Math.Sqrt(args.Length);
            Console.Write($"\nResult is:\n\n\t");

            for (int col = 1; col < lenght; col++)
            {
                Console.Write($"{args[0, col]}\t");
            }
            Console.Write("\n");
            for (int row = 1; row < lenght; row++)
            {
                for (int col = 0; col < lenght; col++)
                {
                    Console.Write($"{args[row, col]}\t");
                }
                Console.Write("\n");
            }
        }

        private int num;
        public int ReadNum()
        {
            Console.Write("Insert valid positive number: ");
            string input = Console.ReadLine();
            Validate(input ?? "");

            return num;
        }

        private void Validate(string input)
        {
            if (!int.TryParse(input.Trim(), out num) || num <= 0)
            {
                Console.Write("Invalid input\n");
                ReadNum();
            }
        }
    }
}