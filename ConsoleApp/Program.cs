using System;

class Program
{
    static void Main(string[] args)
    {

        
        // Console.WriteLine("Finding the Max length of the SubArray without repeating Characters") ;
        // Console.WriteLine(LongestSubArray.LengthOfLongestSubstring("cadbzabcd"));

        // Console.WriteLine("Reverse an Array");
        // Console.WriteLine(RotateByKelement.ReverseArr([1,2,3,4],0,3));


        // Console.WriteLine("Rotate An Array by K");
        // var arr = RotateByKelement.RotateByK([1,2,3,4,5,6],2);
        // Console.WriteLine("Result: [" + string.Join(", ", arr) + "]");

        Console.WriteLine("Move All Zeros To End :");
        var arr = MoveAllZerosToEnd.Handle([1,2,0,3,2,0,0,4,5,1]);
        Console.WriteLine("Result: [" + string.Join(", ", arr) + "]");

    }
}