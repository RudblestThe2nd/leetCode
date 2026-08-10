// 6 - Zigzag Conversion - Medium
// Task: Arrange a string in a zigzag pattern across a given number of rows, then read it row by row.
// Official link: https://leetcode.com/problems/zigzag-conversion/
// Difficulty: Medium
// Question number: 6
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Satir Bazli Simulasyon - her satir icin bir metin biriktirici olustur, yon degistirerek gez.
// Zaman Karmasikligi: O(n) - her karakter bir kez islenir.
// Alan Karmasikligi: O(n) - satir biriktiricileri toplam giris uzunlugu kadar yer tutar.

using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        StringBuilder[] satirlar = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
        {
            satirlar[i] = new StringBuilder();
        }

        int mevcutSatir = 0;
        bool asagiGidiyor = false;

        for (int indeks = 0; indeks < s.Length; indeks++)
        {
            satirlar[mevcutSatir].Append(s[indeks]);

            if (mevcutSatir == 0 || mevcutSatir == numRows - 1)
            {
                asagiGidiyor = !asagiGidiyor;
            }

            mevcutSatir += asagiGidiyor ? 1 : -1;
        }

        StringBuilder sonuc = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            sonuc.Append(satirlar[i]);
        }

        return sonuc.ToString();
    }
}
