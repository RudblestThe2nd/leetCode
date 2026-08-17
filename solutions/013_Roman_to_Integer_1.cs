// 13 - Roman to Integer - Easy
// Task: Convert a Roman numeral string into its integer value.
// Official link: https://leetcode.com/problems/roman-to-integer/
// Difficulty: Easy
// Question number: 13
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Harita (Dictionary) tabanli, saga dogru gezip onceki degerle karsilastirma.
// Zaman Karmasikligi: O(n) - string bir kez taranir.
// Alan Karmasikligi: O(1) - sabit boyutlu harita kullanilir.

using System;
using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        var degerler = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int toplam = 0;
        int oncekiDeger = 0;

        for (int indeks = s.Length - 1; indeks >= 0; indeks--)
        {
            int suankiDeger = degerler[s[indeks]];

            if (suankiDeger < oncekiDeger)
            {
                toplam -= suankiDeger;
            }
            else
            {
                toplam += suankiDeger;
            }

            oncekiDeger = suankiDeger;
        }

        return toplam;
    }
}
