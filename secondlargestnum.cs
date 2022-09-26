namespace slnum
{
    class secondlargestnum
    {
        public static void Main(String[] args)
        {
            int[] arr={12, 34, 54, 23, 85, 13, 57, 82, 44};
            int max1, max2;
            max1 = max2 = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] > max1)
                {
                    max2= max1;
                    max1=arr[i];
                }
                else if(arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }
            System.Console.WriteLine("\n Max value is : " + max1);
            System.Console.WriteLine("\n Second Max value is : " + max2);
        }
    }
}