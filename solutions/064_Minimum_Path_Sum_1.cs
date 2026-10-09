// 64 - Minimum Path Sum - Medium
// Task: Find the minimum path sum from top-left to bottom-right in a grid of non-negative numbers.
// Official link: https://leetcode.com/problems/minimum-path-sum/
// Difficulty: Medium
// Question number: 64
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 2D DP (ayri bir dp dizisi kullanilarak)
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(satirSayisi * sutunSayisi)
// Aciklama: Her hucre icin, o hucreye ulasmak icin gereken minimum toplam
// maliyet, ustten ve soldan gelen minimum maliyetlerin kucugu ile hucrenin
// kendi degeri toplanarak hesaplanir.

using System;

public class Solution
{
    public int MinPathSum(int[][] izgara)
    {
        int satirSayisi = izgara.Length;
        int sutunSayisi = izgara[0].Length;

        int[,] dp = new int[satirSayisi, sutunSayisi];

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                int deger = izgara[satir][sutun];

                if (satir == 0 && sutun == 0)
                {
                    dp[satir, sutun] = deger;
                }
                else if (satir == 0)
                {
                    dp[satir, sutun] = dp[satir, sutun - 1] + deger;
                }
                else if (sutun == 0)
                {
                    dp[satir, sutun] = dp[satir - 1, sutun] + deger;
                }
                else
                {
                    int enAz = Math.Min(dp[satir - 1, sutun], dp[satir, sutun - 1]);
                    dp[satir, sutun] = enAz + deger;
                }
            }
        }

        return dp[satirSayisi - 1, sutunSayisi - 1];
    }
}
