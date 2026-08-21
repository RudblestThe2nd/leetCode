// 17 - Letter Combinations of a Phone Number - Medium
// Task: Return all possible letter combinations represented by a string of phone keypad digits.
// Official link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// Difficulty: Medium
// Question number: 17
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Backtracking (geri izleme) - her basamak icin olasi harfleri
// tek tek deneyip, sonraki basamaga ozyinelemeli (recursive) olarak gecer.
// Zaman Karmasikligi: O(4^n * n) - n basamak sayisi, en fazla 4 harf secenegi.
// Alan Karmasikligi: O(n) - ozyineleme derinligi ve gecici dizi icin.

using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    private readonly Dictionary<char, string> harfHaritasi = new Dictionary<char, string>
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

    public IList<string> LetterCombinations(string basamaklar)
    {
        var sonuc = new List<string>();

        if (string.IsNullOrEmpty(basamaklar))
        {
            return sonuc;
        }

        var gecici = new StringBuilder();

        GeriIzle(basamaklar, 0, gecici, sonuc);

        return sonuc;
    }

    private void GeriIzle(string basamaklar, int indeks, StringBuilder gecici, List<string> sonuc)
    {
        if (indeks == basamaklar.Length)
        {
            sonuc.Add(gecici.ToString());
            return;
        }

        string olasiHarfler = harfHaritasi[basamaklar[indeks]];

        for (int harfIndeksi = 0; harfIndeksi < olasiHarfler.Length; harfIndeksi++)
        {
            gecici.Append(olasiHarfler[harfIndeksi]);

            GeriIzle(basamaklar, indeks + 1, gecici, sonuc);

            gecici.Length -= 1;
        }
    }
}
