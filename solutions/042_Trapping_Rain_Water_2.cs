// 42 - Trapping Rain Water - Hard
// Task: Given bar heights, compute how much rainwater can be trapped between them.
// Official link: https://leetcode.com/problems/trapping-rain-water/
// Difficulty: Hard
// Question number: 42
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Dinamik Programlama - Sol/Sag Maksimum Dizileri Onceden Hesaplama
// Her indeks icin solundaki en yuksek bar ve sagindaki en yuksek bari onceden
// hesaplayip diziye kaydediyoruz. Sonra her indekste tutulabilecek su miktarini
// min(solMaksimum, sagMaksimum) - mevcutYukseklik formuluyle buluyoruz.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(n) (iki yardimci dizi icin)

public class Solution
{
    public int Trap(int[] height)
    {
        int uzunluk = height.Length;

        if (uzunluk == 0)
        {
            return 0;
        }

        int[] solMaksimumlar = new int[uzunluk];
        int[] sagMaksimumlar = new int[uzunluk];

        solMaksimumlar[0] = height[0];
        for (int indeks = 1; indeks < uzunluk; indeks++)
        {
            solMaksimumlar[indeks] = Math.Max(solMaksimumlar[indeks - 1], height[indeks]);
        }

        sagMaksimumlar[uzunluk - 1] = height[uzunluk - 1];
        for (int indeks = uzunluk - 2; indeks >= 0; indeks--)
        {
            sagMaksimumlar[indeks] = Math.Max(sagMaksimumlar[indeks + 1], height[indeks]);
        }

        int toplamSu = 0;

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            int suSeviyesi = Math.Min(solMaksimumlar[indeks], sagMaksimumlar[indeks]);
            toplamSu += suSeviyesi - height[indeks];
        }

        return toplamSu;
    }
}
