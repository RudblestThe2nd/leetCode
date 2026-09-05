// 31 - Next Permutation - Medium
// Task: Transform an array into the next lexicographically greater permutation, or the smallest order if none exists.
// Official link: https://leetcode.com/problems/next-permutation/
// Difficulty: Medium
// Question number: 31
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba Kuvvet (Tum Permutasyonlari Uretme)
// Zaman Karmasikligi: O(n! * n) - tum permutasyonlar uretilir ve siralanir
// Alan Karmasikligi: O(n! * n) - tum permutasyonlari saklamak icin
// Turkce aciklama: Dizinin tum permutasyonlari ozyinelemeli olarak uretilip sozluk
// sirasina gore siralanir. Mevcut dizinin bu sirali listede kacinci sirada oldugu bulunur
// ve bir sonraki permutasyon (sondaysa listenin basi) orijinal diziye kopyalanir.

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public void NextPermutation(int[] sayilar)
    {
        var tumPermutasyonlar = new List<int[]>();
        var kullanildiMi = new bool[sayilar.Length];
        var suankiPermutasyon = new int[sayilar.Length];

        var siraliSayilar = sayilar.OrderBy(x => x).ToArray();

        PermutasyonlariUret(siraliSayilar, kullanildiMi, suankiPermutasyon, 0, tumPermutasyonlar);

        int mevcutIndeks = -1;

        for (int i = 0; i < tumPermutasyonlar.Count; i++)
        {
            if (tumPermutasyonlar[i].SequenceEqual(sayilar))
            {
                mevcutIndeks = i;
                break;
            }
        }

        int sonrakiIndeks = (mevcutIndeks + 1) % tumPermutasyonlar.Count;
        var sonrakiPermutasyon = tumPermutasyonlar[sonrakiIndeks];

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = sonrakiPermutasyon[i];
        }
    }

    private void PermutasyonlariUret(int[] siraliSayilar, bool[] kullanildiMi, int[] suankiPermutasyon, int derinlik, List<int[]> tumPermutasyonlar)
    {
        if (derinlik == siraliSayilar.Length)
        {
            tumPermutasyonlar.Add((int[])suankiPermutasyon.Clone());
            return;
        }

        for (int i = 0; i < siraliSayilar.Length; i++)
        {
            if (kullanildiMi[i])
            {
                continue;
            }

            kullanildiMi[i] = true;
            suankiPermutasyon[derinlik] = siraliSayilar[i];

            PermutasyonlariUret(siraliSayilar, kullanildiMi, suankiPermutasyon, derinlik + 1, tumPermutasyonlar);

            kullanildiMi[i] = false;
        }
    }
}
