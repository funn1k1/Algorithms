namespace Algorithms.Sorting;

public class CountingSort
{
    public int[] Sort(int[] numbers)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        int minimum = 0;
        int maximum = 0;
        for (int i = 0; i < res.Length; i++)
        {
            if (maximum < res[i])
            {
                maximum = res[i];
            }
            if (minimum > res[i])
            {
                minimum = res[i];
            }
        }
        int[] bucket = new int[maximum - minimum + 1];
        for (int i = 0; i < res.Length; i++)
        {
            bucket[res[i] - minimum]++;
        }
        Array.Clear(res, 0, res.Length);
        int index = 0;
        for (int i = 0; i < bucket.Length; i++)
        {
            for (int j = 0; j < bucket[i]; j++)
            {
                res[index] = i + minimum;
                index++;
            }
        }
        return res;
    }
}
