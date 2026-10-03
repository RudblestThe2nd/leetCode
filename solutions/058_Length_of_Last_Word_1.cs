// 58 - Length of Last Word - Easy
// Task: Return the length of the last word in a string.
// Official link: https://leetcode.com/problems/length-of-last-word/
// Difficulty: Easy
// Question number: 58
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sondan geriye tarama - once sondaki bosluklar atlanir, ardindan
// son kelimenin basina kadar sayac ile karakterler sayilir.
// Zaman Karmasikligi: O(n) - string en fazla bir kez sondan basa taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int indeks = s.Length - 1;

        while (indeks >= 0 && s[indeks] == ' ')
        {
            indeks--;
        }

        int uzunluk = 0;

        while (indeks >= 0 && s[indeks] != ' ')
        {
            uzunluk++;
            indeks--;
        }

        return uzunluk;
    }
}
