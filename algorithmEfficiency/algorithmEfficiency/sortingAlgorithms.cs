using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class SortingAlgorithms
{
    // Bubble Sort
    [Benchmark]
    public void BubbleSort()
    {
        // Your implementation of Bubble Sort algorithm here
    }

    // Selection Sort
    [Benchmark]
    public void SelectionSort()
    {
        // Your implementation of Selection Sort algorithm here
    }

    // Insertion Sort
    [Benchmark]
    public void InsertionSort()
    {
        // Your implementation of Insertion Sort algorithm here
    }

    // Merge Sort
    [Benchmark]
    public void MergeSort()
    {
        // Your implementation of Merge Sort algorithm here
    }

    // Quick Sort
    [Benchmark]
    public void QuickSort()
    {
        // Your implementation of Quick Sort algorithm here
    }

    // Example usage
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<SortingAlgorithms>();
    }
}
