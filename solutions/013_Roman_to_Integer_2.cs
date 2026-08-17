// 13 - Roman to Integer - Easy
// Task: Convert a Roman numeral string into its integer value.
// Official link: https://leetcode.com/problems/roman-to-integer/
// Difficulty: Easy
// Question number: 13
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki karakterlik ozel durumlari (IV, IX, XL, XC, CD, CM) once kontrol eden
// switch/case tabanli, soldan saga tarama yontemi.
// Zaman Karmasikligi: O(n) - string bir kez taranir.
// Alan Karmasikligi: O(1) - ek veri yapisi kullanilmaz.

using System;

public class Solution
{
    public int RomanToInt(string s)
    {
        int toplam = 0;
        int indeks = 0;
        int uzunluk = s.Length;

        while (indeks < uzunluk)
        {
            if (indeks + 1 < uzunluk)
            {
                string ikili = s.Substring(indeks, 2);

                switch (ikili)
                {
                    case "IV":
                        toplam += 4;
                        indeks += 2;
                        continue;
                    case "IX":
                        toplam += 9;
                        indeks += 2;
                        continue;
                    case "XL":
                        toplam += 40;
                        indeks += 2;
                        continue;
                    case "XC":
                        toplam += 90;
                        indeks += 2;
                        continue;
                    case "CD":
                        toplam += 400;
                        indeks += 2;
                        continue;
                    case "CM":
                        toplam += 900;
                        indeks += 2;
                        continue;
                }
            }

            char harf = s[indeks];

            switch (harf)
            {
                case 'I':
                    toplam += 1;
                    break;
                case 'V':
                    toplam += 5;
                    break;
                case 'X':
                    toplam += 10;
                    break;
                case 'L':
                    toplam += 50;
                    break;
                case 'C':
                    toplam += 100;
                    break;
                case 'D':
                    toplam += 500;
                    break;
                case 'M':
                    toplam += 1000;
                    break;
            }

            indeks += 1;
        }

        return toplam;
    }
}
