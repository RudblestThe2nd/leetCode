// 76 - Minimum Window Substring - Hard
// Task: Find the smallest substring of s that contains all characters required by t.
// Official link: https://leetcode.com/problems/minimum-window-substring/
// Difficulty: Hard
// Question number: 76
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kayan pencere (sliding window) ve iki isaretci teknigi. Sag isaretciyi
// ilerleterek gerekli karakterleri toplar, yeterli sayida karakter toplandiginda
// sol isaretciyi mumkun oldugunca ilerleterek pencereyi kucultmeye calisirim.
// Zaman Karmasikligi: O(metinUzunlugu + hedefUzunlugu)
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

        Dictionary<char, int> gerekenSayimlar = new Dictionary<char, int>();

        foreach (char harf in hedef)
        {
            if (!gerekenSayimlar.ContainsKey(harf))
            {
                gerekenSayimlar[harf] = 0;
            }

            gerekenSayimlar[harf]++;
        }

        int gerekliBenzersizSayisi = gerekenSayimlar.Count;
        int eslesenBenzersizSayisi = 0;

        Dictionary<char, int> penceresSayimlari = new Dictionary<char, int>();

        int sol = 0;
        int enIyiBaslangic = 0;
        int enIyiUzunluk = int.MaxValue;

        for (int sag = 0; sag < metinUzunlugu; sag++)
        {
            char sagHarf = metin[sag];

            if (!penceresSayimlari.ContainsKey(sagHarf))
            {
                penceresSayimlari[sagHarf] = 0;
            }

            penceresSayimlari[sagHarf]++;

            if (gerekenSayimlar.ContainsKey(sagHarf) && penceresSayimlari[sagHarf] == gerekenSayimlar[sagHarf])
            {
                eslesenBenzersizSayisi++;
            }

            while (eslesenBenzersizSayisi == gerekliBenzersizSayisi)
            {
                int mevcutUzunluk = sag - sol + 1;

                if (mevcutUzunluk < enIyiUzunluk)
                {
                    enIyiUzunluk = mevcutUzunluk;
                    enIyiBaslangic = sol;
                }

                char solHarf = metin[sol];
                penceresSayimlari[solHarf]--;

                if (gerekenSayimlar.ContainsKey(solHarf) && penceresSayimlari[solHarf] < gerekenSayimlar[solHarf])
                {
                    eslesenBenzersizSayisi--;
                }

                sol++;
            }
        }

        if (enIyiUzunluk == int.MaxValue)
        {
            return "";
        }

        return metin.Substring(enIyiBaslangic, enIyiUzunluk);
    }
}
