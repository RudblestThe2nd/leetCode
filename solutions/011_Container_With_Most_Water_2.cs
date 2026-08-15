// 11 - Container With Most Water - Medium
// Task: Given vertical line heights, choose two lines that hold the maximum possible amount of water.
// Official link: https://leetcode.com/problems/container-with-most-water/
// Difficulty: Medium
// Question number: 11
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki Isaretci (Two Pointer) - bastan ve sondan baslayip her adimda kisa kenari icten disari kaydir.
// Zaman Karmasikligi: O(n) - tek gecis.
// Alan Karmasikligi: O(1) - sabit ek alan.

using System;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int sol = 0;
        int sag = height.Length - 1;
        int enFazlaSu = 0;

        while (sol < sag)
        {
            int genislik = sag - sol;
            int kisaKenar = Math.Min(height[sol], height[sag]);
            int mevcutAlan = genislik * kisaKenar;

            if (mevcutAlan > enFazlaSu)
            {
                enFazlaSu = mevcutAlan;
            }

            if (height[sol] < height[sag])
            {
                sol++;
            }
            else
            {
                sag--;
            }
        }

        return enFazlaSu;
    }
}
