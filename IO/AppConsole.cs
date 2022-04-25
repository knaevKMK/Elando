namespace IO
{
    public class AppConsole
    {
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