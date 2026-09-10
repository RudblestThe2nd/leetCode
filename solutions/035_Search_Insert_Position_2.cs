// 35 - Search Insert Position - Easy
// Task: Return the index where a target is found in a sorted array, or where it should be inserted.
// Official link: https://leetcode.com/problems/search-insert-position/
// Difficulty: Easy
// Question number: 35
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Linear Scan (Brute Force)
// Diziyi bastan sona tarayarak hedeften buyuk veya esit olan ilk elemani buluyoruz.
// Boyle bir eleman yoksa hedef dizinin sonuna eklenmelidir.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (int indeks = 0; indeks < nums.Length; indeks++)
        {
            if (nums[indeks] >= target)
            {
                return indeks;
            }
        }

        return nums.Length;
    }
}
