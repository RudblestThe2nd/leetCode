// 11 - Container With Most Water - Medium
// Task: Given vertical line heights, choose two lines that hold the maximum possible amount of water.
// Official link: https://leetcode.com/problems/container-with-most-water/
// Difficulty: Medium
// Question number: 11
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Brute Force - tum cift kombinasyonlarini deneyip en fazla suyu tutani bul.
// Zaman Karmasikligi: O(n^2) - her cift icin kontrol.
// Alan Karmasikligi: O(1) - sabit ek alan.

using System;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int enFazlaSu = 0;
        int uzunluk = height.Length;

        for (int sol = 0; sol < uzunluk; sol++)
        {
            for (int sag = sol + 1; sag < uzunluk; sag++)
            {
                int genislik = sag - sol;
                int kisaKenar = Math.Min(height[sol], height[sag]);
                int mevcutAlan = genislik * kisaKenar;

                if (mevcutAlan > enFazlaSu)
                {
                    enFazlaSu = mevcutAlan;
                }
            }
        }

        return enFazlaSu;
    }
}
