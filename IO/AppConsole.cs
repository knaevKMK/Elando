namespace IO
{
    public class AppConsole
    {
        public static void PrintMatrix(long[,] args)
        {
            var lenght = Math.Sqrt(args.Length);
            Console.Write($"\nResult of Multiplicaiton Tables based on Prime numbers with count {lenght-1} is:\n\n\t");
            for (int col = 1; col < lenght; col++)
            {
                Console.Write($"{args[0, col]}\t");
            }
            Console.WriteLine("\n");
            for (int row = 1; row < lenght; row++)
            {
                for (int col = 0; col < lenght; col++)
                {
                    Console.Write($"{args[row, col]}\t");
                }
                Console.WriteLine("\n");
            }
        }

        private int num;
        public int ReadNum()
        {
            Console.Write("Please enter valid positive number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input.Trim(), out num) || num <= 0)
            {
                Console.WriteLine("Invalid input");
                ReadNum();
            }

            return num;
        }
    }
}