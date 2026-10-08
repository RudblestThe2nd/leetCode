// 62 - Unique Paths - Medium
// Task: Count how many unique paths exist from the top-left to bottom-right of an m by n grid.
// Official link: https://leetcode.com/problems/unique-paths/
// Difficulty: Medium
// Question number: 62
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matematiksel kombinasyon - toplam (m-1)+(n-1) adimdan (m-1) tanesinin
// asagi adim olarak secilme sayisi binom katsayisi C(m+n-2, m-1) ile hesaplanir.
// Zaman Karmasikligi: O(min(m,n)) - binom katsayisi dongu ile hesaplanir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        long sonuc = 1;
        int toplamAdim = m + n - 2;
        int seciliAdim = Math.Min(m - 1, n - 1);

        for (int adim = 1; adim <= seciliAdim; adim++)
        {
            sonuc = sonuc * (toplamAdim - seciliAdim + adim) / adim;
        }

        return (int)sonuc;
    }
}
