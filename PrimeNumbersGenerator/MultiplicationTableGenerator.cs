namespace Generator
{
    public class MultiplicationTableGenerator
    {
        public static long[,] Generate(long[] nums)
        {
            int length = nums.Length + 1;
            var result = new long[length, length];

            GenerateRow(ref result, ref nums, 0, 1);

            for (int row = 1; row < length; row++)
            {
                var multiplyer = nums[row - 1];
                result[row, 0] = multiplyer;

                GenerateRow(ref result, ref nums, row, multiplyer);

            }

            return result;
        }

        private static void GenerateRow(ref long[,] result, ref long[] nums, int row, long multiplyer)
        {
            for (int col = 1; col < nums.Length + 1; col++)
            {
                result[row, col] = nums[col - 1] * multiplyer;
            }
        }
    }
}
