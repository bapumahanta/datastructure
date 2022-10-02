using System;
namespace datastructure 
{
   class MyBubbleSort 
    {
      public static void bubblesort()
        {
            int[] arr = {45,87,30,20,97,63,75,34,88,65,30,27,45,30,48,99};
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