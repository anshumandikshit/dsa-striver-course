//An given Array : [1,2,3,4,5,6]   -> length : 6  rotate the Array by K =2 element from Left
//Output : [3,4,5,6,1,2]

public static class RotateByKelement {
    
  public static int[] RotateByK(int[] arr , int k)
    {
        int length = arr.Length ;
        k = k % length ;
        ReverseArr(arr,0,k-1);
        ReverseArr(arr,k,length-1);
        ReverseArr(arr,0,length-1);
        return arr ;

    }

    public static int[] ReverseArr(int[] arr,int start , int end)
    {
        while(start< end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }

        return arr ;
    }

}


//The Logic
//reverse the arr from k%length that is 
//k = k% length = 2%6 = 2
// that means reverse([1,2]) -> from 0 to k-1  -> [2,1,3,4,5,6]
// then reverse([3,4,5,6]) -> from k to N-1 ->[2,1,6,5,4,3]
// Then reverse the entire Array -> reverse([2,1,6,5,4,3]) from 0 to n-1 -> result : [3,4,5,6,1,2]


