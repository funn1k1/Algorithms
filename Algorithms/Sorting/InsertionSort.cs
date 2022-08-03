namespace Algorithms.Sorting;

public class InsertionSort
{
    public int[] Sort(int[] numbers)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        for (int i = 1; i < res.Length; i++)
        {
            int cur = res[i];
            int j = i - 1;
            while (j >= 0 && res[j] > cur)
            {
                res[j + 1] = res[j];
                j--;
            }
            res[j + 1] = cur;
        }
        return res;
    }
}
