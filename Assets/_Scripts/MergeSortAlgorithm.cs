using UnityEngine;

public class MergeSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Sort")]
    void Sort()
    {
        Debug.Log($"Non-Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");

        int[] tempArray = new int[nonSortedArr.Length];
        MergeSort(nonSortedArr, tempArray, 0, nonSortedArr.Length - 1);

        Debug.Log($"Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private static void MergeSort(int[] array, int[] tempArray, int left, int right)
    {
        if (left >= right) return; // Base case

        int middle = left + (right - left) / 2; // Avoids overflow

        MergeSort(array, tempArray, left, middle);
        MergeSort(array, tempArray, middle + 1, right);
        Merge(array, tempArray, left, middle, right);
    }

    private static void Merge(int[] array, int[] tempArray, int left, int middle, int right)
    {
        int leftIndex = left;
        int rightIndex = middle + 1;
        int mergedIndex = left;

        // Merge both halves into tempArray
        while (leftIndex <= middle && rightIndex <= right)
        {
            if (array[leftIndex] <= array[rightIndex])
            {
                tempArray[mergedIndex] = array[leftIndex];
                leftIndex++;
            }
            else
            {
                tempArray[mergedIndex] = array[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        // Copy remaining elements of left half (if any)
        while (leftIndex <= middle)
        {
            tempArray[mergedIndex] = array[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copy remaining elements of right half (if any)
        while (rightIndex <= right)
        {
            tempArray[mergedIndex] = array[rightIndex];
            rightIndex++;
            mergedIndex++;
        }

        // Copy merged elements back into the original array
        for (int i = left; i <= right; i++)
        {
            array[i] = tempArray[i];
        }
    }
}