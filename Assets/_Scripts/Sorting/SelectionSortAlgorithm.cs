using UnityEngine;

public class SelectionSortAlgorithm : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Execute")]
    private void Execute()
    {
        Debug.Log($"Non-Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");

        SelectionSort(nonSortedArr);

        Debug.Log($"Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
    }

    private void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            if (min != i)
                (array[min], array[i]) = (array[i], array[min]);
        }
    }
}