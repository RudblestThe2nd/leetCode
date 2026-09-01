// 28 - Find the Index of the First Occurrence in a String - Easy
// Task: Return the first index where one string appears inside another, or -1 if it does not appear.
// Official link: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
// Difficulty: Easy
// Question number: 28
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba Kuvvet (Brute Force)
// Zaman Karmasikligi: O(n*m) - n ana metnin, m hedef metnin uzunlugu
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz
// Turkce aciklama: Ana metnin her olasi baslangic pozisyonundan itibaren hedef metin
// karakter karakter karsilastirilir. Tam eslesme bulunursa baslangic indeksi dondurulur.

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

        for (int baslangic = 0; baslangic <= anaUzunluk - hedefUzunluk; baslangic++)
        {
            int sayac = 0;

            while (sayac < hedefUzunluk && ana[baslangic + sayac] == hedef[sayac])
            {
                sayac++;
            }

            if (sayac == hedefUzunluk)
            {
                return baslangic;
            }
        }

        return -1;
    }
}
