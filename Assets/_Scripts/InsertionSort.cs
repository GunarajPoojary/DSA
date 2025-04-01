using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    public int[] nonSortedArr;

    [ContextMenu("Sort")]
    void Sort()
    {
        Debug.Log($"Non-Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
        for (int i = 1; i < nonSortedArr.Length; i++)
        {
            int temp = nonSortedArr[i];
            int j = i - 1;
            while (j >= 0 && nonSortedArr[j] > temp)
            {
                nonSortedArr[j + 1] = nonSortedArr[j];
                j--;
            }
            nonSortedArr[j + 1] = temp;
        }
        Debug.Log($"Swapped array: {{ {string.Join(", ", nonSortedArr)} }}");
        Debug.Log("\n==================================================");
        Debug.Log("                                    🍕 MIDNIGHT PIZZA FIGHT 🍕           ");
        Debug.Log("==================================================");
    }
}