namespace Algorithms.Math
{
    public class EuclideanAlgorithm
    {
        public int Residue(int n1, int n2)
        {
            // Residue method
            int gcd;
            while (n1 !=0 && n2 != 0)
            {
                if (n1 > n2)
                {
                    n1 %= n2;
                }
                else
                {
                    n2 %= n1;
                }
            }
            gcd = n1 + n2;
            return gcd;
        }

        public int Sub(int n1, int n2)
        {
            int gcd = 0;
            // Substraction method
            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 -= n2;
                }
                else
                {
                    n2 -= n1;
                }
            }
            gcd = n1;
            return gcd;
        }

        public int Recursion(int val1, int val2)
        {
            return (val2 == 0) ? val1 : Recursion(val2, val1 % val2);
        }
    }
}
