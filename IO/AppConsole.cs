namespace IO
{
    public class AppConsole
    {
        public static void PrintMatrix(long[,] args)
        {
            var lenght = Math.Sqrt(args.Length);
            Console.Write($"\nResult is:\n\n\t");
           
            PrintRow(ref args,ref lenght, 0, 1);
           
            Console.Write("\n");
            for (int row = 1; row < lenght; row++)
            {
                PrintRow(ref args,ref lenght, row, 0);
              
                Console.Write("\n");
            }
        }

        private static void PrintRow(ref long[,] args,ref double lenght, int row, int start)
        {
            for (int col = start; col < lenght; col++)
            {
                Console.Write($"{args[row, col]}\t");
            }
        }


        private int num;
        public int ReadNum()
        {
            Console.Write("Insert valid positive number: ");
            string input = Console.ReadLine();
            ValidateInput(input ?? "");

            return num;
        }

        private void ValidateInput(string input)
        {
            if (!int.TryParse(input.Trim(), out num) || num <= 0)
            {
                Console.Write("Invalid input\n");
                ReadNum();
            }
        }
    }
}