namespace Algorithms.Sorting;

public class RadixSort
{
    public int GetMaxVal(int[] array, int size)
    {
        var maxVal = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] > maxVal)
            {
                maxVal = array[i];
            }
        }
        return maxVal;
    }

    public int[] Sort(int[] array, int size)
    {
        var maxVal = GetMaxVal(array, size);
        for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
        {
            CountingSort(array, size, exponent);
        }
        return array;
    }

    public void CountingSort(int[] array, int size, int exponent)
    {
        var outputArr = new int[size];
        var occurences = new int[10];
        for (int i = 0; i < 10; i++)
            occurences[i] = 0;
        for (int i = 0; i < size; i++)
            occurences[(array[i] / exponent) % 10]++;
        for (int i = 1; i < occurences.Length; i++)
            occurences[i] += occurences[i - 1];
        for (int i = 0; i < size; i++)
        {
            outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
            occurences[(array[i] / exponent) % 10]--;
        }
        for (int i = 0; i < size; i++)
            array[i] = outputArr[i];
    }
}
