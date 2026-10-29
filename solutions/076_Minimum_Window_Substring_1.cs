// 76 - Minimum Window Substring - Hard
// Task: Find the smallest substring of s that contains all characters required by t.
// Official link: https://leetcode.com/problems/minimum-window-substring/
// Difficulty: Hard
// Question number: 76
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba kuvvet (brute force). Metnin butun alt dizilerini tek tek uretip
// her birinin hedef karakterleri icerip icermedigini kontrol ediyoruz, en kisa
// gecerli olani saklayoruz.
// Zaman Karmasikligi: O(metinUzunlugu^3) (alt dizi uretimi ve icerik kontrolu)
// Alan Karmasikligi: O(hedefUzunlugu)

using System.Collections.Generic;

public class Solution
{
    public string MinWindow(string metin, string hedef)
    {
        int metinUzunlugu = metin.Length;
        int hedefUzunlugu = hedef.Length;

        if (hedefUzunlugu == 0 || metinUzunlugu < hedefUzunlugu)
        {
            return "";
        }

        string enKisaPencere = "";
        int enKisaUzunluk = int.MaxValue;

        for (int baslangic = 0; baslangic < metinUzunlugu; baslangic++)
        {
            for (int bitis = baslangic; bitis < metinUzunlugu; bitis++)
            {
                int aday_uzunluk = bitis - baslangic + 1;

                if (aday_uzunluk >= enKisaUzunluk)
                {
                    continue;
                }

                string aday = metin.Substring(baslangic, aday_uzunluk);

                if (IcerirMi(aday, hedef))
                {
                    enKisaUzunluk = aday_uzunluk;
                    enKisaPencere = aday;
                }
            }
        }

        return enKisaPencere;
    }

    private bool IcerirMi(string aday, string hedef)
    {
        Dictionary<char, int> gerekenSayimlar = new Dictionary<char, int>();

        foreach (char harf in hedef)
        {
            if (!gerekenSayimlar.ContainsKey(harf))
            {
                gerekenSayimlar[harf] = 0;
            }

            gerekenSayimlar[harf]++;
        }

        Dictionary<char, int> mevcutSayimlar = new Dictionary<char, int>();

        foreach (char harf in aday)
        {
            if (!mevcutSayimlar.ContainsKey(harf))
            {
                mevcutSayimlar[harf] = 0;
            }

            mevcutSayimlar[harf]++;
        }

        foreach (KeyValuePair<char, int> ikili in gerekenSayimlar)
        {
            if (!mevcutSayimlar.ContainsKey(ikili.Key) || mevcutSayimlar[ikili.Key] < ikili.Value)
            {
                return false;
            }
        }

        return true;
    }
}
