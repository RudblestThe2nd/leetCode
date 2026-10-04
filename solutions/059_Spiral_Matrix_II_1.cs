// 59 - Spiral Matrix II - Medium
// Task: Create an n by n matrix filled with numbers from 1 to n squared in spiral order.
// Official link: https://leetcode.com/problems/spiral-matrix-ii/
// Difficulty: Medium
// Question number: 59
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sinir takibi (boundary tracking) - ust, alt, sol, sag sinirlari
// tutarak sayilar sirayla bu sinirlar boyunca yerlestirilir.
// Zaman Karmasikligi: O(n^2) - matrisin her hucresine bir kez yazilir.
// Alan Karmasikligi: O(n^2) - sonuc matrisi icin kullanilan alan.

public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] matris = new int[n][];

        for (int satir = 0; satir < n; satir++)
        {
            matris[satir] = new int[n];
        }

        int ustSinir = 0;
        int altSinir = n - 1;
        int solSinir = 0;
        int sagSinir = n - 1;
        int sayac = 1;

        while (ustSinir <= altSinir && solSinir <= sagSinir)
        {
            for (int sutun = solSinir; sutun <= sagSinir; sutun++)
            {
                matris[ustSinir][sutun] = sayac++;
            }
            ustSinir++;

            for (int satir = ustSinir; satir <= altSinir; satir++)
            {
                matris[satir][sagSinir] = sayac++;
            }
            sagSinir--;

            if (ustSinir <= altSinir)
            {
                for (int sutun = sagSinir; sutun >= solSinir; sutun--)
                {
                    matris[altSinir][sutun] = sayac++;
                }
                altSinir--;
            }

            if (solSinir <= sagSinir)
            {
                for (int satir = altSinir; satir >= ustSinir; satir--)
                {
                    matris[satir][solSinir] = sayac++;
                }
                solSinir++;
            }
        }

        return matris;
    }
}
