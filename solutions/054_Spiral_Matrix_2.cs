// 54 - Spiral Matrix - Medium
// Task: Return all elements of a matrix in spiral order.
// Official link: https://leetcode.com/problems/spiral-matrix/
// Difficulty: Medium
// Question number: 54
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Katman katman (layer by layer) simulasyon - matrisin en dis
// katmanindan basyalarak icten disa dogru her katman sirayla islenir.
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

        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;
        int katmanSayisi = (Math.Min(satirSayisi, sutunSayisi) + 1) / 2;

        for (int katman = 0; katman < katmanSayisi; katman++)
        {
            int ilkSatir = katman;
            int ilkSutun = katman;
            int sonSatir = satirSayisi - 1 - katman;
            int sonSutun = sutunSayisi - 1 - katman;

            for (int sutun = ilkSutun; sutun <= sonSutun; sutun++)
            {
                sonuc.Add(matris[ilkSatir][sutun]);
            }

            for (int satir = ilkSatir + 1; satir <= sonSatir; satir++)
            {
                sonuc.Add(matris[satir][sonSutun]);
            }

            if (ilkSatir != sonSatir)
            {
                for (int sutun = sonSutun - 1; sutun >= ilkSutun; sutun--)
                {
                    sonuc.Add(matris[sonSatir][sutun]);
                }
            }

            if (ilkSutun != sonSutun)
            {
                for (int satir = sonSatir - 1; satir > ilkSatir; satir--)
                {
                    sonuc.Add(matris[satir][ilkSutun]);
                }
            }
        }

        return sonuc;
    }
}
