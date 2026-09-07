// 33 - Search in Rotated Sorted Array - Medium
// Task: Search for a target in a rotated sorted array and return its index or -1.
// Official link: https://leetcode.com/problems/search-in-rotated-sorted-array/
// Difficulty: Medium
// Question number: 33
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Modifiye Binary Search (tek gecis)
// Dizi rotasyonlu olsa da her adimda hangi yarinin siralanmis oldugunu tespit edip
// hedefin o yarida olup olmadigina bakarak arama alanini daraltiyoruz.
// Zaman Karmasikligi: O(log n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int sol = 0;
        int sag = nums.Length - 1;

        while (sol <= sag)
        {
            int orta = sol + (sag - sol) / 2;

            if (nums[orta] == target)
            {
                return orta;
            }

            // Sol taraf siralanmis mi kontrol et
            if (nums[sol] <= nums[orta])
            {
                if (target >= nums[sol] && target < nums[orta])
                {
                    sag = orta - 1;
                }
                else
                {
                    sol = orta + 1;
                }
            }
            else
            {
                // Sag taraf siralanmis
                if (target > nums[orta] && target <= nums[sag])
                {
                    sol = orta + 1;
                }
                else
                {
                    sag = orta - 1;
                }
            }
        }

        return -1;
    }
}
