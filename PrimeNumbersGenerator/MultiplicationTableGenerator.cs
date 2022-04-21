namespace Generator
{
    public class MultiplicationTableGenerator
    {
        public long[,] Generate(long[] nums)
        {
            int length = nums.Length + 1;
            var result = new long[length, length];

            for (int col = 1; col < length; col++)
            {
                result[0, col] = nums[col-1];
            }

            for (int row = 1; row < length; row++)
            {
                var index = nums[row-1];
                result[row, 0] = index;
                for (int col = 1; col < length; col++)
                {
                    result[row, col] = nums[col-1] * index;
                }
            }

            return result;
        }
    }
}
