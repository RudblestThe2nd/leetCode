// 85 - Maximal Rectangle - Hard
// Task: Find the largest rectangle containing only 1s in a binary matrix.
// Official link: https://leetcode.com/problems/maximal-rectangle/
// Difficulty: Hard
// Question number: 85
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Her satiri histogram yuksekligine cevirip yigin tabanli
// "Largest Rectangle in Histogram" cozumunu tekrar tekrar uygulama
// Zaman Karmasikligi: O(satir * sutun) - her satir icin dogrusal yigin taramasi
// Alan Karmasikligi: O(sutun) - yukseklik dizisi ve yigin icin
// Aciklama: Matrisin her satirinda, yukaridan asagi '1' sayisini biriktirerek
// bir yukseklik dizisi olusturuyoruz. Bu dizide en buyuk dikdortgen alanini
// artan yigin yontemiyle hesaplayip tum satirlarin en buyugunu tutuyoruz.
public class Solution
{
    public int MaximalRectangle(char[][] matris)
    {
        if (matris.Length == 0 || matris[0].Length == 0)
        {
            return 0;
        }

        int sutunSayisi = matris[0].Length;
        int[] yukseklikler = new int[sutunSayisi];
        int enBuyukAlan = 0;

        foreach (var satir in matris)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (satir[sutun] == '1')
                {
                    yukseklikler[sutun]++;
                }
                else
                {
                    yukseklikler[sutun] = 0;
                }
            }

            int alan = EnBuyukHistogramAlani(yukseklikler);
            if (alan > enBuyukAlan)
            {
                enBuyukAlan = alan;
            }
        }

        return enBuyukAlan;
    }

    private int EnBuyukHistogramAlani(int[] yukseklikler)
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
