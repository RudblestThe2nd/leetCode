// 84 - Largest Rectangle in Histogram - Hard
// Task: Find the largest rectangle area that can be formed in a histogram.
// Official link: https://leetcode.com/problems/largest-rectangle-in-histogram/
// Difficulty: Hard
// Question number: 84
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Artan yigin (monotonic stack) kullanan tek gecis cozumu
// Zaman Karmasikligi: O(n) - her indeks yigina en fazla bir kez girip bir kez cikar
// Alan Karmasikligi: O(n) - yigin icin ek alan
// Aciklama: Yukseklikleri artan sirada tutan bir yigin kullaniyoruz.
// Mevcut yukseklik yigin tepesindekinden kucukse, yigindan cikan her
// eleman icin genislik hesaplayip alani guncelliyoruz.
public class Solution
{
    public int LargestRectangleArea(int[] yukseklikler)
    {
        var yigin = new System.Collections.Generic.Stack<int>();
        int enBuyukAlan = 0;
        int uzunluk = yukseklikler.Length;

        for (int indeks = 0; indeks <= uzunluk; indeks++)
        {
            int guncelYukseklik = (indeks == uzunluk) ? 0 : yukseklikler[indeks];

            while (yigin.Count > 0 && yukseklikler[yigin.Peek()] >= guncelYukseklik)
            {
                int tepeIndeks = yigin.Pop();
                int yukseklik = yukseklikler[tepeIndeks];
                int genislik = yigin.Count == 0 ? indeks : indeks - yigin.Peek() - 1;
                int alan = yukseklik * genislik;

                if (alan > enBuyukAlan)
                {
                    enBuyukAlan = alan;
                }
            }

            yigin.Push(indeks);
        }

        return enBuyukAlan;
    }
}
