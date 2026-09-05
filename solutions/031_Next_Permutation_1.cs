// 31 - Next Permutation - Medium
// Task: Transform an array into the next lexicographically greater permutation, or the smallest order if none exists.
// Official link: https://leetcode.com/problems/next-permutation/
// Difficulty: Medium
// Question number: 31
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Standart Yerinde (In-place) Algoritma
// Zaman Karmasikligi: O(n) - dizi en fazla birkac defa taranir
// Alan Karmasikligi: O(1) - sadece sabit sayida yardimci degisken kullanilir
// Turkce aciklama: Sagdan sola giderek azalmayan (yani artan) bir sinir noktasi bulunur.
// Bu noktadaki eleman, sagindaki kendisinden buyuk en kucuk elemanla degistirilir, sonra
// sinir noktasinin sagi kalan kisim tersine cevrilerek en kucuk siraya getirilir.

public class Solution
{
    public void NextPermutation(int[] sayilar)
    {
        int uzunluk = sayilar.Length;
        int pivotIndeks = uzunluk - 2;

        while (pivotIndeks >= 0 && sayilar[pivotIndeks] >= sayilar[pivotIndeks + 1])
        {
            pivotIndeks--;
        }

        if (pivotIndeks >= 0)
        {
            int degisimIndeks = uzunluk - 1;

            while (sayilar[degisimIndeks] <= sayilar[pivotIndeks])
            {
                degisimIndeks--;
            }

            Degistir(sayilar, pivotIndeks, degisimIndeks);
        }

        TersCevir(sayilar, pivotIndeks + 1, uzunluk - 1);
    }

    private void Degistir(int[] sayilar, int birinciIndeks, int ikinciIndeks)
    {
        int gecici = sayilar[birinciIndeks];
        sayilar[birinciIndeks] = sayilar[ikinciIndeks];
        sayilar[ikinciIndeks] = gecici;
    }

    private void TersCevir(int[] sayilar, int sol, int sag)
    {
        while (sol < sag)
        {
            Degistir(sayilar, sol, sag);
            sol++;
            sag--;
        }
    }
}
