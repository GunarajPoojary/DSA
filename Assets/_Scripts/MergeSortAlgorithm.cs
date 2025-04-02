using UnityEngine;

public class MergeSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Execute")]
    private void Execute()
    {
        Debug.Log($"Non-Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");

        MergeSort(nonSortedArr);

        Debug.Log($"Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private void MergeSort(int[] array)
    {
        int length = array.Length;
        if (length <= 1) return;

        int middle = length / 2;
        int[] leftArr = new int[middle];
        int[] rightArr = new int[length - middle];

        int i = 0;
        int j = 0;

        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftArr[i] = array[i];
            }
            else
            {
                rightArr[j] = array[i];
                j++;
            }
        }

        MergeSort(leftArr);
        MergeSort(rightArr);
        Merge(leftArr, rightArr, array);
    }

    private void Merge(int[] leftArr, int[] rightArr, int[] array)
    {
        int leftSize = array.Length / 2;
        int rightSize = array.Length - leftSize;
        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArr[l] < rightArr[r])
            {
                array[i] = leftArr[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightArr[r];
                i++;
                r++;
            }
        }

        while (l < leftSize)
        {
            array[i] = leftArr[l];
            i++;
            l++;
        }

        while (r < rightSize)
        {
            array[i] = rightArr[r];
            i++;
            r++;
        }
    }
}