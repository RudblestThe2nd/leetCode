// 58 - Length of Last Word - Easy
// Task: Return the length of the last word in a string.
// Official link: https://leetcode.com/problems/length-of-last-word/
// Difficulty: Easy
// Question number: 58
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Trim ve Split kullanarak - bosluklar temizlenip string bosluklara
// gore parcalara ayrilir, son parcanin uzunlugu dondurulur.
// Zaman Karmasikligi: O(n) - string uzunlugu ile orantili islem yapilir.
// Alan Karmasikligi: O(n) - split sonucu olusan kelime dizisi icin yer ayrilir.

using System.Linq;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] kelimeler = s.Trim().Split(' ');
        string sonKelime = kelimeler.Last();
        return sonKelime.Length;
    }
}
