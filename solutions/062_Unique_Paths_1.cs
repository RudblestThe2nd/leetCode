// 62 - Unique Paths - Medium
// Task: Count how many unique paths exist from the top-left to bottom-right of an m by n grid.
// Official link: https://leetcode.com/problems/unique-paths/
// Difficulty: Medium
// Question number: 62
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 2D Dinamik Programlama - her hucreye ulasan yol sayisi, ust ve
// sol hucrelerden gelen yol sayilarinin toplami olarak hesaplanan bir tabloda tutulur.
// Zaman Karmasikligi: O(m*n) - tablonun her hucresi bir kez doldurulur.
// Alan Karmasikligi: O(m*n) - m satir n sutunluk tablo icin kullanilan alan.

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] tablo = new int[m, n];

        for (int satir = 0; satir < m; satir++)
        {
            for (int sutun = 0; sutun < n; sutun++)
            {
                if (satir == 0 || sutun == 0)
                {
                    tablo[satir, sutun] = 1;
                }
                else
                {
                    tablo[satir, sutun] = tablo[satir - 1, sutun] + tablo[satir, sutun - 1];
                }
            }
        }

        return tablo[m - 1, n - 1];
    }
}
