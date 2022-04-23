namespace Generator
{
    public class NumbersGenerator
    {
        public long[] Generate(int Length)
        {
            var result = new long[Length];
            int index = 0;
            long checkNum = 2;
            while (index < Length)
            {
                if (isPrime(checkNum))
                {
                    result[index++] = checkNum;
                }
                checkNum++;
            }
            return result;
        }

        private bool isPrime(long num)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                {
                    {
                        isPrime = false;
                        break;
                    }
                }
            return isPrime;
        }
    }
}
