using Algorithms;
using Algorithms.Sorting;

int[] numbers = { 1, 0, 10, 5, 5, 4 };
Console.WriteLine("Selection_Sort:");
SelectionSort selectSort = new();
int[] res = selectSort.Sort(numbers);
Logger.Log(res);

Console.WriteLine("Bubble_Sort:");
BubbleSort bubbleSort = new();
res = bubbleSort.Sort(numbers);
Logger.Log(res);

Console.WriteLine("Insertion_Sort:");
InsertionSort insSort = new();
res = insSort.Sort(numbers);
Logger.Log(res);

Console.WriteLine("Counting_Sort:");
CountingSort countSort = new();
res = countSort.Sort(numbers);
Logger.Log(res);

Console.WriteLine("Merge_Sort:");
MergeSort mergeSort = new();
res = mergeSort.Sort(numbers);
Logger.Log(res);

Console.WriteLine("Quick_Sort:");
QuickSort quickSort = new();
res = quickSort.Sort(numbers, 0, numbers.Length - 1);
Logger.Log(res);

Console.WriteLine("Radix sort:");
RadixSort radixSort = new();
res = radixSort.Sort(numbers, numbers.Length);
Logger.Log(res);