using Algorithms;
using Algorithms.Math;
using Algorithms.Sorting;

Console.WriteLine("-----------------------Sorting algorithms-----------------------");
int[] numbers = { 1, 0, 10, 5, 5, 4 };
Console.WriteLine("Selection_Sort:");
SelectionSort selectSort = new();
int[] res = selectSort.Sort(numbers);
Logger.LogArr(res);

Console.WriteLine("Bubble_Sort:");
BubbleSort bubbleSort = new();
res = bubbleSort.Sort(numbers);
Logger.LogArr(res);

Console.WriteLine("Insertion_Sort:");
InsertionSort insSort = new();
res = insSort.Sort(numbers);
Logger.LogArr(res);

Console.WriteLine("Counting_Sort:");
CountingSort countSort = new();
res = countSort.Sort(numbers);
Logger.LogArr(res);

Console.WriteLine("Merge_Sort:");
MergeSort mergeSort = new();
res = mergeSort.Sort(numbers);
Logger.LogArr(res);

Console.WriteLine("Quick_Sort:");
QuickSort quickSort = new();
res = quickSort.Sort(numbers, 0, numbers.Length - 1);
Logger.LogArr(res);

Console.WriteLine("Radix sort:");
RadixSort radixSort = new();
res = radixSort.Sort(numbers, numbers.Length);
Logger.LogArr(res);

Console.WriteLine("-----------------------Math-----------------------");

Console.WriteLine("Binary Explonentiation:");
BinaryExp binExp = new();
int n1 = binExp.Power1(2, 3);
int n2 = binExp.Power2(2, 4);
Console.WriteLine("n1(2^3): {0}\nn2(2^4): {1}", n1, n2);

Console.WriteLine();

Console.WriteLine("Binary Search:");
BinarySearch binSearch = new();
Array.Sort(res);
Console.Write("Source array: ");
foreach (var n in numbers)
{
    Console.Write($"{n} | ");
}
Console.WriteLine();
int number;
number = binSearch.Search(res, 2);
Console.WriteLine("Number = {0}", number);

Console.WriteLine();

Console.WriteLine("Euclid's algorithm:");
EuclideanAlgorithm euclidAlg = new();
Console.Write("Sub method: ");
number = euclidAlg.Sub(3, 6);
Console.WriteLine("Number = {0}", number);
Console.Write("Residue method: ");
number = euclidAlg.Residue(12, 8);
Console.WriteLine("Number = {0}", number);
Console.Write("Recursion method: ");
number = euclidAlg.Recursion(12, 8);
Console.WriteLine("Number = {0}", number);

Console.WriteLine();

Console.WriteLine("Sieve of Eratosthenes:");
PrimesSieve sieve = new();
res = sieve.Run(30);
Logger.LogArr(res);
