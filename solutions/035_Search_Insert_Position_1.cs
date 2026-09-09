// 35 - Search Insert Position - Easy
// Task: Return the index where a target is found in a sorted array, or where it should be inserted.
// Official link: https://leetcode.com/problems/search-insert-position/
// Difficulty: Easy
// Question number: 35
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Binary Search
// Siralanmis dizide hedefi ararken, bulunamazsa dongu sonunda "sol" indeksi
// dogal olarak hedefin eklenmesi gereken pozisyonu verir.
// Zaman Karmasikligi: O(log n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int SearchInsert(int[] nums, int target)
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
            else if (nums[orta] < target)
            {
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return sol;
    }
}
