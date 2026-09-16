// 41 - First Missing Positive - Hard
// Task: Find the smallest missing positive integer from an unsorted array, ideally in linear time and constant extra space.
// Official link: https://leetcode.com/problems/first-missing-positive/
// Difficulty: Hard
// Question number: 41
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: HashSet Kullanarak
// Dizideki tum sayilari bir HashSet'e atiyoruz, sonra 1'den baslayarak
// HashSet icinde bulunmayan ilk pozitif sayiyi ariyoruz.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(n) (ekstra HashSet icin)

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        HashSet<int> sayilarKumesi = new HashSet<int>();

        foreach (int sayi in nums)
        {
            sayilarKumesi.Add(sayi);
        }

        int adaySayi = 1;

        while (sayilarKumesi.Contains(adaySayi))
        {
            adaySayi++;
        }

        return adaySayi;
    }
}
