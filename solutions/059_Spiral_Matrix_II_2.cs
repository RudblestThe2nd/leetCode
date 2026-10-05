// 59 - Spiral Matrix II - Medium
// Task: Create an n by n matrix filled with numbers from 1 to n squared in spiral order.
// Official link: https://leetcode.com/problems/spiral-matrix-ii/
// Difficulty: Medium
// Question number: 59
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Katman katman (layer by layer) doldurma - matris disaridan iceriye
// dogru katmanlara bolunur, her katmanin dort kenari sirayla doldurulur.
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

        int sayac = 1;
        int katmanSayisi = (n + 1) / 2;

        for (int katman = 0; katman < katmanSayisi; katman++)
        {
            int ilkSatir = katman;
            int ilkSutun = katman;
            int sonSatir = n - 1 - katman;
            int sonSutun = n - 1 - katman;

            for (int sutun = ilkSutun; sutun <= sonSutun; sutun++)
            {
                matris[ilkSatir][sutun] = sayac++;
            }

            for (int satir = ilkSatir + 1; satir <= sonSatir; satir++)
            {
                matris[satir][sonSutun] = sayac++;
            }

            if (ilkSatir != sonSatir)
            {
                for (int sutun = sonSutun - 1; sutun >= ilkSutun; sutun--)
                {
                    matris[sonSatir][sutun] = sayac++;
                }
            }

            if (ilkSutun != sonSutun)
            {
                for (int satir = sonSatir - 1; satir > ilkSatir; satir--)
                {
                    matris[satir][ilkSutun] = sayac++;
                }
            }
        }

        return matris;
    }
}
