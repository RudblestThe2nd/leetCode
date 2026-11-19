// 97 - Interleaving String - Medium
// Task: Determine whether a string can be formed by interleaving two other strings while preserving their internal order.
// Official link: https://leetcode.com/problems/interleaving-string/
// Difficulty: Medium
// Question number: 97
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Asagi-yukari (bottom-up) dinamik programlama, 2 boyutlu tablo ile.
// tablo[i][j], s1'in ilk i ve s2'nin ilk j karakteriyle s3'un ilk (i+j) karakterinin olusturulup olusturulamayacagini tutar.
// Zaman Karmasikligi: O(uzunluk1 * uzunluk2) - her hucre bir kez hesaplanir.
// Alan Karmasikligi: O(uzunluk1 * uzunluk2) - 2 boyutlu dogruluk tablosu icin.

public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int uzunluk1 = s1.Length;
        int uzunluk2 = s2.Length;

        if (uzunluk1 + uzunluk2 != s3.Length)
        {
            return false;
        }

        bool[,] tablo = new bool[uzunluk1 + 1, uzunluk2 + 1];

        tablo[0, 0] = true;

        for (int i = 1; i <= uzunluk1; i++)
        {
            tablo[i, 0] = tablo[i - 1, 0] && s1[i - 1] == s3[i - 1];
        }

        for (int j = 1; j <= uzunluk2; j++)
        {
            tablo[0, j] = tablo[0, j - 1] && s2[j - 1] == s3[j - 1];
        }

        for (int i = 1; i <= uzunluk1; i++)
        {
            for (int j = 1; j <= uzunluk2; j++)
            {
                bool sol = tablo[i - 1, j] && s1[i - 1] == s3[i + j - 1];
                bool ust = tablo[i, j - 1] && s2[j - 1] == s3[i + j - 1];

                tablo[i, j] = sol || ust;
            }
        }

        return tablo[uzunluk1, uzunluk2];
    }
}
