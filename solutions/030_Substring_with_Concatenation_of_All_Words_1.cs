// 30 - Substring with Concatenation of All Words - Hard
// Task: Find all starting indices where a substring is formed by concatenating each given word exactly once.
// Official link: https://leetcode.com/problems/substring-with-concatenation-of-all-words/
// Difficulty: Hard
// Question number: 30
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba Kuvvet (Brute Force)
// Zaman Karmasikligi: O(n * k) - n metnin uzunlugu, k kelime sayisi ile kelime uzunlugunun carpimi
// Alan Karmasikligi: O(k) - her pencerede kullanilan kelimeleri takip eden sozluk
// Turkce aciklama: Metindeki her olasi baslangic pozisyonu icin, o pencerenin tum
// kelimelerin birlestirilmesiyle olusup olusmadigi dogrudan kontrol edilir. Her adimda
// kelime uzunlugunda parcalar okunup bir sayac sozlugu ile karsilastirilir.

using System.Collections.Generic;

public class Solution
{
    public IList<int> FindSubstring(string metin, string[] kelimeler)
    {
        var sonucListesi = new List<int>();

        if (metin.Length == 0 || kelimeler.Length == 0)
        {
            return sonucListesi;
        }

        int kelimeUzunlugu = kelimeler[0].Length;
        int kelimeSayisi = kelimeler.Length;
        int toplamUzunluk = kelimeUzunlugu * kelimeSayisi;

        if (metin.Length < toplamUzunluk)
        {
            return sonucListesi;
        }

        var beklenenSayaclar = new Dictionary<string, int>();

        foreach (var kelime in kelimeler)
        {
            if (!beklenenSayaclar.ContainsKey(kelime))
            {
                beklenenSayaclar[kelime] = 0;
            }

            beklenenSayaclar[kelime]++;
        }

        for (int baslangic = 0; baslangic <= metin.Length - toplamUzunluk; baslangic++)
        {
            var suankiSayaclar = new Dictionary<string, int>();
            int sayac = 0;

            while (sayac < kelimeSayisi)
            {
                int parcaBaslangici = baslangic + sayac * kelimeUzunlugu;
                string parca = metin.Substring(parcaBaslangici, kelimeUzunlugu);

                if (!beklenenSayaclar.ContainsKey(parca))
                {
                    break;
                }

                if (!suankiSayaclar.ContainsKey(parca))
                {
                    suankiSayaclar[parca] = 0;
                }

                suankiSayaclar[parca]++;

                if (suankiSayaclar[parca] > beklenenSayaclar[parca])
                {
                    break;
                }

                sayac++;
            }

            if (sayac == kelimeSayisi)
            {
                sonucListesi.Add(baslangic);
            }
        }

        return sonucListesi;
    }
}
