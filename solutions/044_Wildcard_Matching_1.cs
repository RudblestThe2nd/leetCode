// 44 - Wildcard Matching - Hard
// Task: Implement wildcard pattern matching for a full string using '?' and '*' rules.
// Official link: https://leetcode.com/problems/wildcard-matching/
// Difficulty: Hard
// Question number: 44
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Dinamik Programlama (2 boyutlu tablo)
// dp[i][j], metnin ilk i karakteri ile desenin ilk j karakterinin
// eslesip eslesmedigini tutar. '*' karakteri hem bos string hem de
// bir veya daha fazla karakteri temsil edebilecegi icin iki durumu
// birlestiririz.
// Zaman Karmasikligi: O(metin.Uzunluk * desen.Uzunluk)
// Alan Karmasikligi: O(metin.Uzunluk * desen.Uzunluk)

public class Solution
{
    public bool IsMatch(string metin, string desen)
    {
        int metinUzunlugu = metin.Length;
        int desenUzunlugu = desen.Length;

        bool[,] tablo = new bool[metinUzunlugu + 1, desenUzunlugu + 1];

        tablo[0, 0] = true;

        for (int j = 1; j <= desenUzunlugu; j++)
        {
            if (desen[j - 1] == '*')
            {
                tablo[0, j] = tablo[0, j - 1];
            }
        }

        for (int i = 1; i <= metinUzunlugu; i++)
        {
            for (int j = 1; j <= desenUzunlugu; j++)
            {
                char desenKarakteri = desen[j - 1];

                if (desenKarakteri == '*')
                {
                    tablo[i, j] = tablo[i - 1, j] || tablo[i, j - 1];
                }
                else if (desenKarakteri == '?' || desenKarakteri == metin[i - 1])
                {
                    tablo[i, j] = tablo[i - 1, j - 1];
                }
                else
                {
                    tablo[i, j] = false;
                }
            }
        }

        return tablo[metinUzunlugu, desenUzunlugu];
    }
}
