namespace Generator
{
    public class MultiplicationTableGenerator
    {
        public static void Generate(long[] nums)
        {
            Console.Write($"\nResult is:\n\n\t");

            PrintRow(ref nums, 1);

            for (int row = 0; row < nums.Length; row++)
            {
                Console.Write($"{nums[row]}\t");
                PrintRow(ref nums, nums[row]);
            
            }
        }

        private static void PrintRow(ref long[] nums, long multiplyer)
        {
            for (int col = 0; col < nums.Length; col++)
            {
                Console.Write($"{ nums[col] * multiplyer}\t");
            }
            Console.Write("\n");
        }
    }
}
