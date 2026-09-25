// 49 - Group Anagrams - Medium
// Task: Group strings that are anagrams of each other.
// Official link: https://leetcode.com/problems/group-anagrams/
// Difficulty: Medium
// Question number: 49
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Harf Sayim Imzasi ile Harita (Character Count Signature)
// Siralama yapmadan, her kelime icin 26 harflik bir sayim dizisi
// olusturup bunu string'e cevirerek anahtar yapariz. Anagramlar ayni
// sayim imzasina sahip olur. Siralamadan daha hizli olabilir.
// Zaman Karmasikligi: O(kelimeSayisi * ortalamaUzunluk)
// Alan Karmasikligi: O(kelimeSayisi * ortalamaUzunluk)

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] kelimeler)
    {
        Dictionary<string, List<string>> harita = new Dictionary<string, List<string>>();

        foreach (string kelime in kelimeler)
        {
            int[] harfSayaci = new int[26];

            foreach (char harf in kelime)
            {
                harfSayaci[harf - 'a']++;
            }

            StringBuilder imzaOlusturucu = new StringBuilder();

            for (int indeks = 0; indeks < 26; indeks++)
            {
                imzaOlusturucu.Append('#');
                imzaOlusturucu.Append(harfSayaci[indeks]);
            }

            string imza = imzaOlusturucu.ToString();

            if (!harita.ContainsKey(imza))
            {
                harita[imza] = new List<string>();
            }

            harita[imza].Add(kelime);
        }

        IList<IList<string>> sonuc = new List<IList<string>>();

        foreach (List<string> grup in harita.Values)
        {
            sonuc.Add(grup);
        }

        return sonuc;
    }
}
