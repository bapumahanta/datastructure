namespace datastructure
{
    class MyMainProgram
    {   
        public static void Main(String[] args)
        {
            int choice = 0;

            Console.WriteLine("\n1. Binary Search");
            Console.WriteLine("\n2. Linear Search");
            Console.WriteLine("\n3. Bubble Sort");
            Console.WriteLine("\n4. Quick Sort");
            Console.WriteLine("\n5. Selection Sort");
            Console.WriteLine("\n6. Type Conversion");
            Console.WriteLine("\n7. Find Second Largest Number");

            Console.WriteLine("\n\n\nEnter your Choice above : " );
            choice = Convert.ToInt16(Console.ReadLine());
            
            switch(choice)
            {
                case 1: Console.WriteLine("\nDoing Binary Search......\n");
                        MyBinarySearch.binarysearch();
                        break;
                case 2: MyLinearSearch.linearsearch();
                        break;
                case 3: MyBubbleSort.bubblesort();
                        break;
                case 4: MyQuickSort.quicksort();
                        break;
                case 5: MySelectionSort.selectionsort();
                        break;
                case 6: Conversion.conversion();
                        break;
                case 7: SecondLargestNumber.secondlargestnumber();
                        break;

            }
        }
    }
}