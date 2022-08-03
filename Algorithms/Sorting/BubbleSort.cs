namespace Algorithms.Sorting;

public class BubbleSort
{
    public int[] Sort(int[] numbers)
    {
        int[] res = new int[numbers.Length];
        Array.Copy(numbers, res, numbers.Length);
        bool swapRequired;
        for (int i =  0; i < res.Length - 1; i++)
        {
            swapRequired = false;
            for (int j = 0; j < res.Length - i - 1; j++)
            {
                if (res[j] > res[j + 1])
                {
                    swapRequired = true;
                    Swap(ref res[j + 1], ref res[j]);
                }
            }
            if (!swapRequired)
                break;
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