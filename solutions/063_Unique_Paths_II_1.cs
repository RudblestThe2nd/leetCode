// 63 - Unique Paths II - Medium
// Task: Count unique grid paths when some cells are blocked by obstacles.
// Official link: https://leetcode.com/problems/unique-paths-ii/
// Difficulty: Medium
// Question number: 63
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 2D DP (iki boyutlu dp dizisi ile)
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(satirSayisi * sutunSayisi)
// Aciklama: Her hucre icin, engel varsa yol sayisi 0'dir. Degilse ustten ve
// soldan gelen yol sayilari toplanir. Sonuc en sag alt hucrededir.

public class Solution
{
    public int UniquePathsWithObstacles(int[][] engelIzgarasi)
    {
        int satirSayisi = engelIzgarasi.Length;
        int sutunSayisi = engelIzgarasi[0].Length;

        int[,] dp = new int[satirSayisi, sutunSayisi];

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (engelIzgarasi[satir][sutun] == 1)
                {
                    dp[satir, sutun] = 0;
                    continue;
                }

                if (satir == 0 && sutun == 0)
                {
                    dp[satir, sutun] = 1;
                    continue;
                }

                int ustten = (satir > 0) ? dp[satir - 1, sutun] : 0;
                int soldan = (sutun > 0) ? dp[satir, sutun - 1] : 0;

                dp[satir, sutun] = ustten + soldan;
            }
        }

        return dp[satirSayisi - 1, sutunSayisi - 1];
    }
}
