namespace Algorithms.Sorting;

public class MergeSort
{
    public int[] Sort(int[] numbers)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        if (res.Length == 1)
        {
            return numbers;
        }
        int[] left = new int[res.Length / 2];
        int[] right = new int[res.Length - left.Length];
        int leftIndex = 0, rightIndex = 0;
        for (int i = 0; i < left.Length; i++)
        {
            left[leftIndex++] = res[i];
        }
        for (int i = left.Length; i < res.Length; i++)
        {
            right[rightIndex++] = res[i];
        }
        Sort(left);
        Sort(right);
        res = Merge(left, right);
        return res;
    }

    private int[] Merge(int[] left, int[] right)
    {
        int[] merged = new int[right.Length + left.Length];
        int index = 0;
        int leftIndex = 0, rightIndex = 0;
        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] < right[rightIndex])
            {
                merged[index] = left[leftIndex++];
            }
            else
            {
                merged[index] = right[rightIndex++];
            }
            index++;
        }
        while (leftIndex < left.Length)
        {
            merged[index++] = left[leftIndex++];
        }
        while (rightIndex < right.Length)
        {
            merged[index++] = right[rightIndex++];
        }
        return merged;
    }
}
