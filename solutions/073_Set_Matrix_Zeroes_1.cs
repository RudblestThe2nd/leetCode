// 73 - Set Matrix Zeroes - Medium
// Task: If a matrix cell is zero, set its entire row and column to zero in place.
// Official link: https://leetcode.com/problems/set-matrix-zeroes/
// Difficulty: Medium
// Question number: 73
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ekstra iki dizi (satir ve sutun isaretleri) kullanan basit yontem.
// Once hangi satir ve sutunlarin sifirlanmasi gerektigini ayri dizilerde isaretliyoruz,
// sonra ikinci bir gecis ile isaretli satir/sutunlardaki tum degerleri sifirliyoruz.
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(satirSayisi + sutunSayisi)

public class Solution
{
    public void SetZeroes(int[][] matris)
    {
        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;

        bool[] sifirliSatirlar = new bool[satirSayisi];
        bool[] sifirliSutunlar = new bool[sutunSayisi];

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][sutun] == 0)
                {
                    sifirliSatirlar[satir] = true;
                    sifirliSutunlar[sutun] = true;
                }
            }
        }

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (sifirliSatirlar[satir] || sifirliSutunlar[sutun])
                {
                    matris[satir][sutun] = 0;
                }
            }
        }
    }
}
