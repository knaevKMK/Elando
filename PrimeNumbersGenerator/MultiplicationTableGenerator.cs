using IO;

namespace Generator
{
    public class MultiplicationTableGenerator
    {
        public static void Generate(long[] nums)
        {
            var table = new ConsoleTable();

            table.SetHeaders(PrintRow(ref nums, 1));

            for (int row = 0; row < nums.Length; row++)
            {
                table.AddRow(PrintRow(ref nums, nums[row]));
            }
            Console.WriteLine(table.ToString());
        }

        private static string[] PrintRow(ref long[] nums, long multiplyer)
        {
            var result = new string[nums.Length + 1];
            result[0] = multiplyer == 1 ? "" : multiplyer.ToString();

            for (int col = 1; col < nums.Length + 1; col++)
            {
                result[col] = ($"{ nums[col - 1] * multiplyer}");
            }

            return result;
        }
    }
}
