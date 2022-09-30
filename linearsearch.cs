using System;

namespace datastructure
{
    class MyLinearSearch
    {
        public static int linearsearch(int[] array, int n, int item)
        {
            // Going through array sequencially
            for (int i = 0; i < n; i++)
                if (array[i] == item)
                    return i;
            return -1;
        }

        public void linearsearch()   // while runing the program, change the funtion name to "main"
        {
            int[] array = { 20, 60, 10, 15, 40 };
            int searchitem = 15;
            int n = array.Length;

            int result = linearsearch(array, n, searchitem);

            Console.Write("\nArray List : ");
            for (int i = 0; i < n; i++)
                Console.Write(array[i] +", ");
            var output = (result == -1) ? "\nElement not found." : "\nElement " + searchitem + " found at index: " + result;        
            Console.WriteLine(output);
        }
    }
}