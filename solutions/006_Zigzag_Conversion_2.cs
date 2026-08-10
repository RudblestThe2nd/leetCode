// 6 - Zigzag Conversion - Medium
// Task: Arrange a string in a zigzag pattern across a given number of rows, then read it row by row.
// Official link: https://leetcode.com/problems/zigzag-conversion/
// Difficulty: Medium
// Question number: 6
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matematiksel Desen (Pattern) - her satirdaki karakterlerin indeksini formul ile dogrudan hesapla.
// Zaman Karmasikligi: O(n) - her karakter bir kez ziyaret edilir.
// Alan Karmasikligi: O(n) - sonuc metni icin kullanilan alan.

using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        StringBuilder sonuc = new StringBuilder();
        int dongusuzunlugu = 2 * numRows - 2;
        int uzunluk = s.Length;

        for (int satir = 0; satir < numRows; satir++)
        {
            for (int baslangic = satir; baslangic < uzunluk; baslangic += dongusuzunlugu)
            {
                sonuc.Append(s[baslangic]);

                if (satir != 0 && satir != numRows - 1)
                {
                    int aynaIndeks = baslangic + dongusuzunlugu - 2 * satir;
                    if (aynaIndeks < uzunluk)
                    {
                        sonuc.Append(s[aynaIndeks]);
                    }
                }
            }
        }

        return sonuc.ToString();
    }
}
