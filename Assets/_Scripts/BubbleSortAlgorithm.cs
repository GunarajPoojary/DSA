using System;
using System.Collections;
using UnityEngine;

public class BubbleSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Execute")]
    private void Execute()
    {
        Debug.Log($"Non-Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");

        BubbleSort(nonSortedArr);

        Debug.Log($"Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
}