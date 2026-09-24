// 49 - Group Anagrams - Medium
// Task: Group strings that are anagrams of each other.
// Official link: https://leetcode.com/problems/group-anagrams/
// Difficulty: Medium
// Question number: 49
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Siralanmis Anahtar ile Harita (Sorted Key Hashing)
// Her kelimenin harflerini siraladigimizda, anagramlar ayni anahtari
// uretir. Bu anahtari sozluk anahtari olarak kullanip kelimeleri
// gruplariz.
// Zaman Karmasikligi: O(kelimeSayisi * ortalamaUzunluk * log(ortalamaUzunluk))
// Alan Karmasikligi: O(kelimeSayisi * ortalamaUzunluk)

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] kelimeler)
    {
        Dictionary<string, List<string>> harita = new Dictionary<string, List<string>>();

        foreach (string kelime in kelimeler)
        {
            char[] harfler = kelime.ToCharArray();

            Array.Sort(harfler);

            string anahtar = new string(harfler);

            if (!harita.ContainsKey(anahtar))
            {
                harita[anahtar] = new List<string>();
            }

            harita[anahtar].Add(kelime);
        }

        IList<IList<string>> sonuc = new List<IList<string>>();

        foreach (List<string> grup in harita.Values)
        {
            sonuc.Add(grup);
        }

        return sonuc;
    }
}
