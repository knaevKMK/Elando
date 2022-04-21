namespace IO
{
    public class AppConsole
    {
        public static void Print(int[] args)
        {
            Console.WriteLine(string.Join(" " , args));
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