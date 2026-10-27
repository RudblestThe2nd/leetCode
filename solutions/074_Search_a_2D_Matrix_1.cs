// 74 - Search a 2D Matrix - Medium
// Task: Search for a target in a matrix whose rows are sorted and connected in sorted order.
// Official link: https://leetcode.com/problems/search-a-2d-matrix/
// Difficulty: Medium
// Question number: 74
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba kuvvet (brute force). Matrisin tum hucrelerini tek tek tarayarak
// hedef degeri ariyoruz. Basit ama satir/sutun siralamasindan faydalanmiyor.
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(1)

public class Solution
{
    public bool SearchMatrix(int[][] matris, int hedef)
    {
        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][sutun] == hedef)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
