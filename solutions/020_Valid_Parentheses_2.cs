// 20 - Valid Parentheses - Easy
// Task: Check whether brackets in a string are correctly opened and closed in order.
// Official link: https://leetcode.com/problems/valid-parentheses/
// Difficulty: Easy
// Question number: 20
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Tekrarli degistirme (String Replacement) - gecerli parantez
// ciftlerini ("()", "[]", "{}") string bos kalana kadar tekrar tekrar sil.
// Zaman Karmasikligi: O(n^2) - her degistirme islemi string uzerinde tarama gerektirir.
// Alan Karmasikligi: O(n) - her adimda yeni string olusturulur.

using System;

public class Solution
{
    public bool IsValid(string s)
    {
        string mevcutMetin = s;
        int oncekiUzunluk = -1;

        while (mevcutMetin.Length != oncekiUzunluk)
        {
            oncekiUzunluk = mevcutMetin.Length;

            mevcutMetin = mevcutMetin.Replace("()", "");
            mevcutMetin = mevcutMetin.Replace("[]", "");
            mevcutMetin = mevcutMetin.Replace("{}", "");
        }

        return mevcutMetin.Length == 0;
    }
}
