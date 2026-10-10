// 64 - Minimum Path Sum - Medium
// Task: Find the minimum path sum from top-left to bottom-right in a grid of non-negative numbers.
// Official link: https://leetcode.com/problems/minimum-path-sum/
// Difficulty: Medium
// Question number: 64
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: In-place DP (girdi dizisini degistirerek, ekstra alan kullanmadan)
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(1) (girdi dizisi disinda ekstra alan kullanilmaz)
// Aciklama: Girdi olarak gelen izgaranin kendisi guncellenir. Her hucre,
// kendi degerine ustten veya soldan gelen en kucuk toplam eklenerek
// kumulatif minimum maliyete donusturulur.

using System;

public class Solution
{
    public int MinPathSum(int[][] izgara)
    {
        int satirSayisi = izgara.Length;
        int sutunSayisi = izgara[0].Length;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (satir == 0 && sutun == 0)
                {
                    continue;
                }
                else if (satir == 0)
                {
                    izgara[satir][sutun] += izgara[satir][sutun - 1];
                }
                else if (sutun == 0)
                {
                    izgara[satir][sutun] += izgara[satir - 1][sutun];
                }
                else
                {
                    int enAz = Math.Min(izgara[satir - 1][sutun], izgara[satir][sutun - 1]);
                    izgara[satir][sutun] += enAz;
                }
            }
        }

        return izgara[satirSayisi - 1][sutunSayisi - 1];
    }
}
