// Generate Longest SubsString/SubArray withoqut repeating characters
//c,a,d,b,z,a,b,c,d  -> 5
//slidingWindow Pattern solve
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class LongestSubArray
{
    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int l = 0, r = 0, maxLength = 0;
        while (r < s.Length)
        {
            if (!charIndex.ContainsKey(s[r]))
            {
                charIndex[s[r]] = r; //index like c:0,a:1
                maxLength = Math.Max(maxLength, (r - l + 1));
                r = r + 1;

            }
            else
            {
                if (charIndex[s[r]]> l)
                {
                    l = charIndex[s[r]] + 1;
                }
                
                charIndex[s[r]] = r ;
                maxLength = Math.Max(maxLength, (r - l + 1));
                r = r + 1;
            }
        }

        return maxLength ;

    }
}

// Algorithm: Longest Substring Without Repeating Characters
// Sliding Window + Dictionary approach
//
// Flow Explanation:
// - We maintain two pointers: l (left) and r (right) to represent the current window.
// - Dictionary<char,int> stores the last seen index of each character.
// - As we expand r, we check if s[r] already exists in the dictionary:
//    1. If NOT present → add it, update maxLength with current window size (r - l + 1).
//    2. If PRESENT → move l to (last seen index + 1) to skip the duplicate,
//       then update dictionary with the new index of s[r].
// - At each step, maxLength = max(maxLength, current window size).
// - Continue until r reaches end of string.
//
// Example: "cadbzabcd"
// Step by step:
// r=0 'c' → add c:0, window="c", maxLength=1
// r=1 'a' → add a:1, window="ca", maxLength=2
// r=2 'd' → add d:2, window="cad", maxLength=3
// r=3 'b' → add b:3, window="cadb", maxLength=4
// r=4 'z' → add z:4, window="cadbz", maxLength=5
// r=5 'a' → duplicate at index 1, move l=2, update a:5, window="dbza", maxLength=5
// r=6 'b' → duplicate at index 3, move l=4, update b:6, window="za b", maxLength=5
// r=7 'c' → old index 0 < l=4, safe, update c:7, window="zac", maxLength=5
// r=8 'd' → old index 2 < l=4, safe, update d:8, window="zacd", maxLength=5
// End → longest substring length = 5
//
// Key Idea: Expand window until duplicate, then shrink from left past duplicate.
// This ensures substring always has unique characters.
