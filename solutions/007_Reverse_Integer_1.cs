// 7 - Reverse Integer - Medium
// Task: Reverse the digits of a signed 32-bit integer and return zero if the result overflows.
// Official link: https://leetcode.com/problems/reverse-integer/
// Difficulty: Medium
// Question number: 7
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matematiksel Iteratif Cevirme - sayiyi 10'a bolerek basamaklari tek tek cikar ve tas kontrolu icin long kullan.
// Zaman Karmasikligi: O(log10(n)) - basamak sayisi kadar dongu.
// Alan Karmasikligi: O(1) - sabit ek alan.

public class Solution
{
    public int Reverse(int x)
    {
        long cevrilmisDeger = 0;
        long kalanSayi = x;

        while (kalanSayi != 0)
        {
            long sonBasamak = kalanSayi % 10;
            cevrilmisDeger = cevrilmisDeger * 10 + sonBasamak;
            kalanSayi = kalanSayi / 10;
        }

        if (cevrilmisDeger < int.MinValue || cevrilmisDeger > int.MaxValue)
        {
            return 0;
        }

        return (int)cevrilmisDeger;
    }
}
