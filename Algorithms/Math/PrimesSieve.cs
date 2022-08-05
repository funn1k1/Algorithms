namespace Algorithms.Math
{
    public class PrimesSieve
    {
        public int[] Run(int n)
        {
            bool[] mark = new bool[n];
            for (int i = 0; i < mark.Length; i++)
            {
                mark[i] = true;
            }
            List<int> primes = new()
            {
                2
            };
            for (int i = 3; i * i <= n; i += 2)
            {
                if (mark[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        mark[j] = false;
                    }
                }
            }

            for (int i = 3; i < mark.Length; i += 2)
            {
                if (mark[i])
                {
                    primes.Add(i);
                }
            }
            return primes.ToArray();
        }
    }
}
