// 30 - Substring with Concatenation of All Words - Hard
// Task: Find all starting indices where a substring is formed by concatenating each given word exactly once.
// Official link: https://leetcode.com/problems/substring-with-concatenation-of-all-words/
// Difficulty: Hard
// Question number: 30
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kayan Pencere (Sliding Window) + Sozluk Sayaci
// Zaman Karmasikligi: O(n * k) - n metnin uzunlugu, k kelime uzunlugu icin kayma ofseti sayisi
// Alan Karmasikligi: O(k) - kelime sayaclarini tutan sozlukler
// Turkce aciklama: Kelime uzunlugu kadar farkli baslangic ofseti (0..kelimeUzunlugu-1)
// icin kayan pencere teknigiyle metin taranir. Pencereye kelime eklenip cikarilirken
// sayaclar guncellenir, fazla veya beklenmeyen kelime geldiginde pencerenin sol ucu
// kaydirilir, boylece her karakter sabit sayida islenir.

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

        for (int ofset = 0; ofset < kelimeUzunlugu; ofset++)
        {
            int solUc = ofset;
            int eslesenSayisi = 0;
            var pencereSayaclari = new Dictionary<string, int>();

            for (int sagUc = ofset; sagUc <= metin.Length - kelimeUzunlugu; sagUc += kelimeUzunlugu)
            {
                string parca = metin.Substring(sagUc, kelimeUzunlugu);

                if (beklenenSayaclar.ContainsKey(parca))
                {
                    if (!pencereSayaclari.ContainsKey(parca))
                    {
                        pencereSayaclari[parca] = 0;
                    }

                    pencereSayaclari[parca]++;
                    eslesenSayisi++;

                    while (pencereSayaclari[parca] > beklenenSayaclar[parca])
                    {
                        string solParca = metin.Substring(solUc, kelimeUzunlugu);
                        pencereSayaclari[solParca]--;
                        eslesenSayisi--;
                        solUc += kelimeUzunlugu;
                    }

                    if (eslesenSayisi == kelimeSayisi)
                    {
                        sonucListesi.Add(solUc);

                        string cikanParca = metin.Substring(solUc, kelimeUzunlugu);
                        pencereSayaclari[cikanParca]--;
                        eslesenSayisi--;
                        solUc += kelimeUzunlugu;
                    }
                }
                else
                {
                    pencereSayaclari.Clear();
                    eslesenSayisi = 0;
                    solUc = sagUc + kelimeUzunlugu;
                }
            }
        }

        return sonucListesi;
    }
}
