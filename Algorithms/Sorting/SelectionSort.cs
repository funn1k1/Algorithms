namespace Algorithms.Sorting;
public class SelectionSort
{
    public int[] Sort(int[] numbers)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        for (int i = 0; i < res.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < res.Length; j++)
            {
                if (res[j] < res[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                 Swap(ref res[minIndex], ref res[i]);
            }
        }
        return res;
    }

    private void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
