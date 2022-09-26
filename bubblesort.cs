using System;
namespace bubblesort 
{
   class MyBubbleSort {
      static void bubblesort(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }            
            }
            for (int i = 0; i < arr.Length; i++)
                 Console.Write(arr[i] + " ");
            // Console.WriteLine("Sorted:");
            // foreach (int p in arr)
            //     Console.Write(p + " ");
            // Console.Read();
        }
    }
}