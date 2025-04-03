using System;
using System.Collections.Concurrent;
using UnityEngine;

public class QuickSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Execute")]
    private void Execute()
    {
        Debug.Log($"Non-Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");

        QuickSort(nonSortedArr, 0, nonSortedArr.Length - 1);

        Debug.Log($"Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private void QuickSort(int[] array, int start, int end)
    {
        if (end <= start) return;

        int pivot = Partition(array, start, end);

        QuickSort(array, start, pivot - 1);
        QuickSort(array, pivot + 1, end);
    }

    private int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];

        int i = start - 1;

        for (int j = start; j < end; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
        i++;
        (array[i], array[end]) = (array[end], array[i]);

        return i;
    }
}