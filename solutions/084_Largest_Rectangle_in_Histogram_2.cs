// 84 - Largest Rectangle in Histogram - Hard
// Task: Find the largest rectangle area that can be formed in a histogram.
// Official link: https://leetcode.com/problems/largest-rectangle-in-histogram/
// Difficulty: Hard
// Question number: 84
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Her cubugu sol sinir olarak deneyen kaba kuvvet (brute force)
// Zaman Karmasikligi: O(n^2) - her baslangic icin sagdaki cubuklari tarama
// Alan Karmasikligi: O(1) - ek veri yapisi kullanilmiyor
// Aciklama: Her indeksi rektangenin en kisa cubugu kabul ederek, sola ve
// saga o yukseklikten daha kisa cubuk bulana kadar genisletiyoruz.
public class Solution
{
    public int LargestRectangleArea(int[] yukseklikler)
    {
        int uzunluk = yukseklikler.Length;
        int enBuyukAlan = 0;

        for (int merkez = 0; merkez < uzunluk; merkez++)
        {
            int guncelYukseklik = yukseklikler[merkez];

            int sol = merkez;
            while (sol > 0 && yukseklikler[sol - 1] >= guncelYukseklik)
            {
                sol--;
            }

            int sag = merkez;
            while (sag < uzunluk - 1 && yukseklikler[sag + 1] >= guncelYukseklik)
            {
                sag++;
            }

            int genislik = sag - sol + 1;
            int alan = guncelYukseklik * genislik;

            if (alan > enBuyukAlan)
            {
                enBuyukAlan = alan;
            }
        }

        return enBuyukAlan;
    }
}
