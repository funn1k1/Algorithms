namespace Algorithms.Math
{
    public class EulerFunction
    {
        public int SimplePhi(int n)
        {
            int count = 1;
            EuclideanAlgorithm euclid = new();
            for (int i = 2; i < n; i++)
            {
                if (euclid.Recursion(i, n) == 1)
                    count++;
            }
            return count;
        }

        public int Phi(int n)
        {
            int result =  n;
            for (int i = 2; i <= System.Math.Sqrt(n); i++) // or (i^2 <= n)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                    }
                    result -= result / i ;
                }
            }
            if (n > 1)
            {
                result -= result / n;
            }
            return result;
        }
    }
}
