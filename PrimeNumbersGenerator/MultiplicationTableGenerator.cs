namespace Generator
{
    public class MultiplicationTableGenerator
    {
        public int[,] Generate(int[] nums)
        {
            int lenght= nums.Length+1;
            return new int[lenght, lenght];
        }
    }
}
