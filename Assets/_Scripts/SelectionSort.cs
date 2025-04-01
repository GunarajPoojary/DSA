using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Sort")]
    void Sort()
    {
        Debug.Log($"Non-Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
        for (int j = 0; j < nonSortedArr.Length - 1; j++)
        {
            int min = j;
            for (int i = j + 1; i < nonSortedArr.Length; i++)
            {
                if (nonSortedArr[min] > nonSortedArr[i])
                {
                    min = i;
                }
            }
            (nonSortedArr[min], nonSortedArr[j]) = (nonSortedArr[j], nonSortedArr[min]);
        }
        Debug.Log($"Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
    }
}
