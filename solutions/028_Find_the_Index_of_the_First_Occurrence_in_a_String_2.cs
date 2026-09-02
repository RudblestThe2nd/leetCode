// 28 - Find the Index of the First Occurrence in a String - Easy
// Task: Return the first index where one string appears inside another, or -1 if it does not appear.
// Official link: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
// Difficulty: Easy
// Question number: 28
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: KMP (Knuth-Morris-Pratt) Algoritmasi
// Zaman Karmasikligi: O(n+m) - n ana metnin, m hedef metnin uzunlugu
// Alan Karmasikligi: O(m) - hedef metin icin onek (prefix) fonksiyonu dizisi
// Turkce aciklama: Once hedef metin icin bir onek fonksiyonu (basarisizlik tablosu)
// hesaplanir. Bu tablo, eslesme basarisiz oldugunda geri sarma yapmadan hangi konumdan
// devam edilecegini gosterir, boylece ana metin yalnizca bir defa taranir.

public class Solution
{
    public int StrStr(string ana, string hedef)
    {
        int anaUzunluk = ana.Length;
        int hedefUzunluk = hedef.Length;

        if (hedefUzunluk == 0)
        {
            return 0;
        }

        int[] onekTablosu = OnekTablosuOlustur(hedef);

        int anaIndeks = 0;
        int hedefIndeks = 0;

        while (anaIndeks < anaUzunluk)
        {
            if (ana[anaIndeks] == hedef[hedefIndeks])
            {
                anaIndeks++;
                hedefIndeks++;

                if (hedefIndeks == hedefUzunluk)
                {
                    return anaIndeks - hedefIndeks;
                }
            }
            else if (hedefIndeks > 0)
            {
                hedefIndeks = onekTablosu[hedefIndeks - 1];
            }
            else
            {
                anaIndeks++;
            }
        }

        return -1;
    }

    private int[] OnekTablosuOlustur(string hedef)
    {
        int uzunluk = hedef.Length;
        int[] tablo = new int[uzunluk];

        int onekUzunluk = 0;

        for (int i = 1; i < uzunluk; i++)
        {
            while (onekUzunluk > 0 && hedef[i] != hedef[onekUzunluk])
            {
                onekUzunluk = tablo[onekUzunluk - 1];
            }

            if (hedef[i] == hedef[onekUzunluk])
            {
                onekUzunluk++;
            }

            tablo[i] = onekUzunluk;
        }

        return tablo;
    }
}
