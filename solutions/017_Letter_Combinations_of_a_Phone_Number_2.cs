// 17 - Letter Combinations of a Phone Number - Medium
// Task: Return all possible letter combinations represented by a string of phone keypad digits.
// Official link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// Difficulty: Medium
// Question number: 17
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif genisletme (BFS benzeri) - sonuc listesi bos bir kelimeyle
// baslar, her basamak icin mevcut tum kombinasyonlar yeni harflerle genisletilir.
// Zaman Karmasikligi: O(4^n * n) - n basamak sayisi, en fazla 4 harf secenegi.
// Alan Karmasikligi: O(4^n) - olusan tum kombinasyonlarin saklanmasi icin.

using System;
using System.Collections.Generic;

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

        sonuc.Add("");

        foreach (char basamak in basamaklar)
        {
            var yeniSonuc = new List<string>();
            string olasiHarfler = harfHaritasi[basamak];

            foreach (string mevcutKelime in sonuc)
            {
                foreach (char harf in olasiHarfler)
                {
                    yeniSonuc.Add(mevcutKelime + harf);
                }
            }

            sonuc = yeniSonuc;
        }

        return sonuc;
    }
}
