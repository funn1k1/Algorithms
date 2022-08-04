namespace Algorithms.Math
{
    public class BinarySearch
    {
        public int Search(int[] numbers, int n)
        {
            int l = 0, r = numbers.Length - 1;
            while (l <= r) {
                int m = (l + r) >> 1;
                if (numbers[m] < n)
                {
                    l = m + 1;
                }
                else if (numbers[m] > n)
                {
                    r = m - 1;
                }
                else
                {
                    return numbers[m];
                }
            }
            return -1;
        } 
    }
}
