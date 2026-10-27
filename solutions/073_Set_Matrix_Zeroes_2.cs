// 73 - Set Matrix Zeroes - Medium
// Task: If a matrix cell is zero, set its entire row and column to zero in place.
// Official link: https://leetcode.com/problems/set-matrix-zeroes/
// Difficulty: Medium
// Question number: 73
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matrisin kendi ilk satir ve ilk sutununu isaretleyici olarak kullanan
// sabit alanli (in-place) yontem. Ilk satir/sutunun orijinal sifir durumunu ayri
// iki bool degiskeninde saklayip, matrisin kendisini isaretleme alani olarak kullaniyoruz.
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(1)

public class Solution
{
    public void SetZeroes(int[][] matris)
    {
        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;

        bool ilkSutunSifirMi = false;
        bool ilkSatirSifirMi = false;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            if (matris[satir][0] == 0)
            {
                ilkSutunSifirMi = true;
            }
        }

        for (int sutun = 0; sutun < sutunSayisi; sutun++)
        {
            if (matris[0][sutun] == 0)
            {
                ilkSatirSifirMi = true;
            }
        }

        for (int satir = 1; satir < satirSayisi; satir++)
        {
            for (int sutun = 1; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][sutun] == 0)
                {
                    matris[satir][0] = 0;
                    matris[0][sutun] = 0;
                }
            }
        }

        for (int satir = 1; satir < satirSayisi; satir++)
        {
            for (int sutun = 1; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][0] == 0 || matris[0][sutun] == 0)
                {
                    matris[satir][sutun] = 0;
                }
            }
        }

        if (ilkSatirSifirMi)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                matris[0][sutun] = 0;
            }
        }

        if (ilkSutunSifirMi)
        {
            for (int satir = 0; satir < satirSayisi; satir++)
            {
                matris[satir][0] = 0;
            }
        }
    }
}
