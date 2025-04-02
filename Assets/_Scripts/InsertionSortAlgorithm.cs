using UnityEngine;

public class InsertionSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Execute")]
    private void Execute()
    {
        Debug.Log($"Non-Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");

        InsertionSort(nonSortedArr);

        Debug.Log($"Sorted array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
    }
}