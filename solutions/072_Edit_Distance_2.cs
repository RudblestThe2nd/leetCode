// 72 - Edit Distance - Medium
// Task: Compute the minimum number of insert, delete, and replace operations needed to convert one word into another.
// Official link: https://leetcode.com/problems/edit-distance/
// Difficulty: Medium
// Question number: 72
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 1D DP (yer tasarrufu optimize edilmis, iki satirlik dizi ile)
// Zaman Karmasikligi: O(birinciUzunluk * ikinciUzunluk)
// Alan Karmasikligi: O(ikinciUzunluk) - sadece iki satir tutulur
// Aciklama: Tam bir 2D matris yerine sadece "onceki satir" ve "guncel satir"
// dizileri tutulur. Her adimda guncel satir hesaplanip onceki satirin yerine
// gecer, boylece bellek kullanimi satir bazinda sinirlanir.

using System;

public class Solution
{
    public int MinDistance(string birinciKelime, string ikinciKelime)
    {
        int birinciUzunluk = birinciKelime.Length;
        int ikinciUzunluk = ikinciKelime.Length;

        int[] oncekiSatir = new int[ikinciUzunluk + 1];
        int[] guncelSatir = new int[ikinciUzunluk + 1];

        for (int sutun = 0; sutun <= ikinciUzunluk; sutun++)
        {
            oncekiSatir[sutun] = sutun;
        }

        for (int satir = 1; satir <= birinciUzunluk; satir++)
        {
            guncelSatir[0] = satir;

            for (int sutun = 1; sutun <= ikinciUzunluk; sutun++)
            {
                if (birinciKelime[satir - 1] == ikinciKelime[sutun - 1])
                {
                    guncelSatir[sutun] = oncekiSatir[sutun - 1];
                }
                else
                {
                    int silme = oncekiSatir[sutun] + 1;
                    int ekleme = guncelSatir[sutun - 1] + 1;
                    int degistirme = oncekiSatir[sutun - 1] + 1;

                    guncelSatir[sutun] = Math.Min(silme, Math.Min(ekleme, degistirme));
                }
            }

            int[] gecici = oncekiSatir;
            oncekiSatir = guncelSatir;
            guncelSatir = gecici;
        }

        return oncekiSatir[ikinciUzunluk];
    }
}
