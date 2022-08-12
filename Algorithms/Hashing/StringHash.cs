namespace Algorithms.Hashing
{
    public class StringHash
    {
        private const int m = (int)1e9 + 7;
        private const int p = 31;

        public void Run()
        {
            string str1 = "aaa";
            string str2 = "abb";
            string str3 = "abb";
            Console.WriteLine(GetHash(str1));
            Console.WriteLine(GetHash(str2));
            Console.WriteLine(GetHash(str3));
            Console.WriteLine(GetHash(str2) == GetHash(str3));
        }

        public long GetHash(string str) // => O(n)
        {
            long hash = 0;
            long prime_pow = 1;
            foreach (char ch in str)
            {
                hash = (hash + (ch - 'a' + 1) * prime_pow) % m;
                prime_pow = (prime_pow * p) % m;
            }
            return hash;
        }
    }
}
