using UnityEngine;

public class QuickSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Sort")]
    void Sort()
    {
        Debug.Log($"Non-Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
        
        QuickSort(nonSortedArr, 0, nonSortedArr.Length - 1);

        Debug.Log($"Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // Choosing the last element as pivot
        int i = low - 1; // Index for the smaller element

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        
        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}