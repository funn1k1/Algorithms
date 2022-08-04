namespace Algorithms;

public static class Logger
{
    public static void LogArr(int[] array)
    {
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
    }
}
