// 32 - Longest Valid Parentheses - Hard
// Task: Find the length of the longest substring of parentheses that forms a valid expression.
// Official link: https://leetcode.com/problems/longest-valid-parentheses/
// Difficulty: Hard
// Question number: 32
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Dinamik Programlama (DP)
// Zaman Karmasikligi: O(n) - dizi bir defa taranir
// Alan Karmasikligi: O(n) - dp dizisi icin
// Turkce aciklama: dp[i], i indeksinde biten en uzun gecerli parantez alt dizisinin
// uzunlugunu tutar. Kapanan bir parantez bulundugunda, esine denk gelen acilis parantezin
// konumuna gore dp degeri hesaplanir ve varsa ondan onceki gecerli blokla birlestirilir.

using System;

public class Solution
{
    public int LongestValidParentheses(string metin)
    {
        int uzunluk = metin.Length;

        if (uzunluk == 0)
        {
            return 0;
        }

        int[] dp = new int[uzunluk];
        int enUzunSonuc = 0;

        for (int i = 1; i < uzunluk; i++)
        {
            if (metin[i] == ')')
            {
                if (metin[i - 1] == '(')
                {
                    dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                }
                else
                {
                    int esleseninOncesi = i - dp[i - 1] - 1;

                    if (esleseninOncesi >= 0 && metin[esleseninOncesi] == '(')
                    {
                        dp[i] = dp[i - 1] + 2 + (esleseninOncesi >= 1 ? dp[esleseninOncesi - 1] : 0);
                    }
                }

                enUzunSonuc = Math.Max(enUzunSonuc, dp[i]);
            }
        }

        return enUzunSonuc;
    }
}
