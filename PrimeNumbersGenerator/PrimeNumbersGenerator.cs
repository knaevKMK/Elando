namespace Generator
{
    public class PrimeNumbersGenerator
    {
        public int[] Generate(int Length)
        {
            var result = new int[Length];
            int index = 0;
            int chenkNum = 2;
            while (index < Length)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(chenkNum); i++)
                    if (chenkNum % i == 0)
                    {
                        {
                            isPrime = false;
                            break;
                        }
                    }
                if (isPrime)
                {
                result[index++] = chenkNum;
                }
                chenkNum++;
            }

            return result;
        }
    }
}
