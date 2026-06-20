using System;

public static class MoveAllZerosToEnd
{
    public static int[] Handle(int[] arr)
    {
        Console.WriteLine($"GivenInput: [{string.Join(", ",arr)}]");
        int i = 0;
        int j = 0;
        while (i < arr.Length)
        {
            if (arr[i] == 0)
            {
                break;
            }
            i++ ;
        }
        Console.WriteLine($"i---->>>{i}");
        j=i+1 ;
        Console.WriteLine($"j---->>>{j}");
        while (j < arr.Length)
        {
            if (arr[j] != 0)
            {
                int temp = arr[j];
                arr[j]=arr[i];
                arr[i]= temp;
                j++;
                i++;
            }
            else
            {
                j++;
            }
        }

        return arr;
    }
}

// [1,2,0,3,2,0,0,4,5,1] -> [1,2,3,2,4,5,1,0,0,0]

//Logic -> Two pointers -> swipe the elements when the i=0 and j= NonZero and increament i and J .
//And When J is 0 then just move the J only .