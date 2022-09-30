using System;
namespace datastructure
{
    class datastructure
    {
        public static void Maintemp(String[] args)
        {
            int[] dataset = {45,87,30,20,97,63,75,34,88,65,30,27,45,30,48,99};
            int totaldata = dataset.Length;
            int i=0;
            quick_sort(dataset, 0, totaldata-1);
            
            for(i=0;i<totaldata;i++)
                Console.WriteLine(dataset[i]);
        }

        public static void quick_sort(int[] ds, int left, int right)    
        {
            int pivot=0;
            if(left<right)  
            {

               pivot = partition(ds,left,right);
               if((pivot+1) < right)
                 quick_sort(ds,(pivot+1),right);
                 if(pivot>1)
                 quick_sort(ds,left,(pivot-1));
            }
        }

        public static int partition(int[] qs, int left, int right)   
        {
            int pivot=qs[left];
            while(true)
            {
                while(qs[left] < pivot)
                left++;
                while(qs[right] > pivot)
                right--;
                if(left<right)
                {
                    if(qs[left]==qs[right])
                     return right;
                    int temp= qs[left];
                    qs[left] = qs[right];
                    qs[right] = temp;
                }
                else
                  
                 return right;     
            } 
        }
    }
}
