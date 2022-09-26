using System;
namespace insertionsort
{
    class MyInsertionSort
    {
        static void insertionsort(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13, 39 };
            int j, temp;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
