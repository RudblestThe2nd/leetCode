// 7 - Reverse Integer - Medium
// Task: Reverse the digits of a signed 32-bit integer and return zero if the result overflows.
// Official link: https://leetcode.com/problems/reverse-integer/
// Difficulty: Medium
// Question number: 7
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Tasma Kontrolunu Onceden Yapma - int sinirlarini asmadan once her adimda kontrol ederek sadece int kullan.
// Zaman Karmasikligi: O(log10(n)) - basamak sayisi kadar dongu.
// Alan Karmasikligi: O(1) - sabit ek alan, long turu kullanilmaz.

public class Solution
{
    public int Reverse(int x)
    {
        int cevrilmisDeger = 0;
        int kalanSayi = x;

        while (kalanSayi != 0)
        {
            int sonBasamak = kalanSayi % 10;
            kalanSayi = kalanSayi / 10;

            if (cevrilmisDeger > int.MaxValue / 10 || (cevrilmisDeger == int.MaxValue / 10 && sonBasamak > 7))
            {
                return 0;
            }

            if (cevrilmisDeger < int.MinValue / 10 || (cevrilmisDeger == int.MinValue / 10 && sonBasamak < -8))
            {
                return 0;
            }

            cevrilmisDeger = cevrilmisDeger * 10 + sonBasamak;
        }

        return cevrilmisDeger;
    }
}
