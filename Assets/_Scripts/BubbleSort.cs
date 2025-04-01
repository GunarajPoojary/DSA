using System.Collections;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Sort")]
    void Sort()
    {
        Debug.Log($"Non-Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");

        for (int j = 0; j < nonSortedArr.Length - 1; j++)
        {
            for (int i = 0; i < nonSortedArr.Length - j - 1; i++)
            {
                if (nonSortedArr[i + 1] < nonSortedArr[i])
                    (nonSortedArr[i], nonSortedArr[i + 1]) = (nonSortedArr[i + 1], nonSortedArr[i]);
            }
        }
        Debug.Log($"Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
    }
}
