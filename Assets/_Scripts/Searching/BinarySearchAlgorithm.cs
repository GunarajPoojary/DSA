using System;
using UnityEngine;

public class BinarySearchAlgorithm : MonoBehaviour
{
    [Range(0, 99)] public int target;

    [ContextMenu("Execute")]
    private void Execute()
    {
        int[] sortedArr = new int[100];

        for (int i = 0; i < sortedArr.Length; i++)
        {
            sortedArr[i] = i;
        }

        int index = BinarySearch(sortedArr, target);

        Debug.Log("Target found at: " + index);
    }

    private int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int middle = low + (high - low) / 2;
            int value = array[middle];

            if (value < target) low = middle - 1;
            else if (value > target) high = middle + 1;
            else return value;
        }

        return -1;
    }
}
