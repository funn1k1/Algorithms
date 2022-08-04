using System;

namespace Algorithms.Math
{
    public class BinaryExp
    {
        public int Power1(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if ((n & 1) == 0)
            {
                int p = Power1(a, n >> 1);
                return p * p;
            }
            else
            {
                return a * Power1(a, n - 1);
            }


        }

        public int Power2(int a, int n)
        {
            // Without recursion
            int result = 1;
            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    a *= a;
                    n >>= 1;
                }
                else
                {
                    result *= a;
                    n--;
                }
            }
            return result;
        }
    }

}