using System;
namespace selectionsort
{
   class MySelectionSort
   {
      static void Main4(string[] args) 
      {
         int[] arr = {45,87,30,20,97,63,75,34,88,65,30,27,45,30,48,99};
         int n = arr.Length;

         Console.WriteLine("Selection sort");
         Console.Write("Initial array is: ");
         for (int i = 0; i < n; i++) 
         {
            Console.Write(arr[i] + " ");
         }
         int temp, smallest;
         for (int i = 0; i < n - 1; i++) 
         {
            smallest = i;
            for (int j = i + 1; j < n; j++) {
               if (arr[j] < arr[smallest]) {
                  smallest = j;
               }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
         }
         Console.WriteLine();
         Console.Write("Sorted array is: ");
         for (int i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
      }
   }
}