// 43 - Multiply Strings - Medium
// Task: Multiply two non-negative integers represented as strings and return the product as a string.
// Official link: https://leetcode.com/problems/multiply-strings/
// Difficulty: Medium
// Question number: 43
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Basamak bazli carpim (Long Multiplication)
// Ilkokulda ogretilen elle carpma yontemini simule ederiz.
// i indeksindeki basamak ile j indeksindeki basamagin carpimi,
// sonuc dizisinde (i + j) ve (i + j + 1) indekslerine katki yapar.
// Zaman Karmasikligi: O(sayi1.Uzunluk * sayi2.Uzunluk)
// Alan Karmasikligi: O(sayi1.Uzunluk + sayi2.Uzunluk)

public class Solution
{
    public string Multiply(string sayi1, string sayi2)
    {
        if (sayi1 == "0" || sayi2 == "0")
        {
            return "0";
        }

        int uzunluk1 = sayi1.Length;
        int uzunluk2 = sayi2.Length;

        int[] basamaklar = new int[uzunluk1 + uzunluk2];

        for (int i = uzunluk1 - 1; i >= 0; i--)
        {
            int rakam1 = sayi1[i] - '0';

            for (int j = uzunluk2 - 1; j >= 0; j--)
            {
                int rakam2 = sayi2[j] - '0';

                int carpim = rakam1 * rakam2;

                int konumUst = i + j;
                int konumAlt = i + j + 1;

                int toplam = carpim + basamaklar[konumAlt];

                basamaklar[konumAlt] = toplam % 10;
                basamaklar[konumUst] += toplam / 10;
            }
        }

        System.Text.StringBuilder tampon = new System.Text.StringBuilder();

        foreach (int basamak in basamaklar)
        {
            if (!(tampon.Length == 0 && basamak == 0))
            {
                tampon.Append(basamak);
            }
        }

        return tampon.Length == 0 ? "0" : tampon.ToString();
    }
}
