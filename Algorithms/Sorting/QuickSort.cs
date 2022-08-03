namespace Algorithms.Sorting;

public class QuickSort
{
    public int[] Sort(int[] numbers, int leftIndex, int rightIndex)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        var i = leftIndex;
        var j = rightIndex;
        var pivot = res[leftIndex];
        while (i <= j)
        {
            while (res[i] < pivot)
            {
                i++;
            }
            while (res[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                Swap(ref res[i], ref res[j]);
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            Sort(res, leftIndex, j);
        if (i < rightIndex)
            Sort(res, i, rightIndex);
        return res;
    }

    private void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
