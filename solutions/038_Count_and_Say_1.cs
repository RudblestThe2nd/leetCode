// 38 - Count and Say - Medium
// Task: Generate the nth term of the count-and-say sequence.
// Official link: https://leetcode.com/problems/count-and-say/
// Difficulty: Medium
// Question number: 38
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Iteratif string olusturma (StringBuilder ile)
// "1" den baslayip her adimda mevcut stringi ardisik karakter gruplarina ayirarak
// (sayi, karakter) ciftlerinden yeni stringi StringBuilder ile insa ediyoruz.
// Zaman Karmasikligi: O(n * m) (n adim, m ortalama string uzunlugu)
// Alan Karmasikligi: O(m) (o anki ve bir onceki string icin)

using System.Text;

public class Solution
{
    public string CountAndSay(int n)
    {
        string mevcutDizi = "1";

        for (int adim = 1; adim < n; adim++)
        {
            StringBuilder yeniDizi = new StringBuilder();
            int indeks = 0;

            while (indeks < mevcutDizi.Length)
            {
                char karakter = mevcutDizi[indeks];
                int sayac = 0;

                while (indeks < mevcutDizi.Length && mevcutDizi[indeks] == karakter)
                {
                    sayac++;
                    indeks++;
                }

                yeniDizi.Append(sayac);
                yeniDizi.Append(karakter);
            }

            mevcutDizi = yeniDizi.ToString();
        }

        return mevcutDizi;
    }
}
