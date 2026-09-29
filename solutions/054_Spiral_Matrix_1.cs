// 54 - Spiral Matrix - Medium
// Task: Return all elements of a matrix in spiral order.
// Official link: https://leetcode.com/problems/spiral-matrix/
// Difficulty: Medium
// Question number: 54
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sinir takibi (boundary tracking) - ust, alt, sol, sag sinirlari
// tutup bu sinirlar daralana kadar sirayla dolasilir.
// Zaman Karmasikligi: O(m*n) - matristeki her eleman bir kez ziyaret edilir.
// Alan Karmasikligi: O(m*n) - sonuc listesi eleman sayisi kadar yer tutar.

using System.Collections.Generic;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matris)
    {
        List<int> sonuc = new List<int>();

        if (matris == null || matris.Length == 0)
        {
            return sonuc;
        }

        int ustSinir = 0;
        int altSinir = matris.Length - 1;
        int solSinir = 0;
        int sagSinir = matris[0].Length - 1;

        while (ustSinir <= altSinir && solSinir <= sagSinir)
        {
            for (int sutun = solSinir; sutun <= sagSinir; sutun++)
            {
                sonuc.Add(matris[ustSinir][sutun]);
            }
            ustSinir++;

            for (int satir = ustSinir; satir <= altSinir; satir++)
            {
                sonuc.Add(matris[satir][sagSinir]);
            }
            sagSinir--;

            if (ustSinir <= altSinir)
            {
                for (int sutun = sagSinir; sutun >= solSinir; sutun--)
                {
                    sonuc.Add(matris[altSinir][sutun]);
                }
                altSinir--;
            }

            if (solSinir <= sagSinir)
            {
                for (int satir = altSinir; satir >= ustSinir; satir--)
                {
                    sonuc.Add(matris[satir][solSinir]);
                }
                solSinir++;
            }
        }

        return sonuc;
    }
}
