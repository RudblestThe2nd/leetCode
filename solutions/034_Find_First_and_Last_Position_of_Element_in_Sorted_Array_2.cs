// 34 - Find First and Last Position of Element in Sorted Array - Medium
// Task: Find the first and last index of a target value in a sorted array.
// Official link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
// Difficulty: Medium
// Question number: 34
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Linear Scan (Brute Force)
// Diziyi bastan sona tek tek tarayarak hedef degerin ilk ve son goruldugu
// indeksleri kaydediyoruz. Basit ama optimal olmayan cozum.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int ilkIndeks = -1;
        int sonIndeks = -1;

        for (int indeks = 0; indeks < nums.Length; indeks++)
        {
            if (nums[indeks] == target)
            {
                if (ilkIndeks == -1)
                {
                    ilkIndeks = indeks;
                }

                sonIndeks = indeks;
            }
        }

        return new int[] { ilkIndeks, sonIndeks };
    }
}
