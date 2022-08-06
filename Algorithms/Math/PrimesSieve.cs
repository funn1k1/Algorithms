namespace Algorithms.Math
{
    public class PrimesSieve
    {
        public int[] Run(int n)
        {
            bool[] prime = new bool[n + 1];
            List<int> primes = new();
            for (int i = 2; i < prime.Length; i++)
            {
                prime[i] = true;
            }
            int limit = (int)System.Math.Ceiling(System.Math.Sqrt(n));
            for (int i = 2; i <= limit; i++)
            {
                if (prime[i])
                {
                    for (int j = i * i; j < prime.Length; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
            for (int i = 2; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    primes.Add(i);
                }
            }
            return primes.ToArray();
        }
    }
}
