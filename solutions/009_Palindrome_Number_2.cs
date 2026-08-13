// 9 - Palindrome Number - Easy
// Task: Determine whether an integer is a palindrome without relying on a string conversion if possible.
// Official link: https://leetcode.com/problems/palindrome-number/
// Difficulty: Easy
// Question number: 9
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yarisini Matematiksel Olarak Ters Cevirme - metin kullanmadan sayinin yarisini ters cevirip karsilastir.
// Zaman Karmasikligi: O(log10(n)) - basamak sayisinin yarisi kadar islem.
// Alan Karmasikligi: O(1) - sabit ek alan.

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int tersCevrilmisYari = 0;
        int kalanSayi = x;

        while (kalanSayi > tersCevrilmisYari)
        {
            int sonBasamak = kalanSayi % 10;
            tersCevrilmisYari = tersCevrilmisYari * 10 + sonBasamak;
            kalanSayi = kalanSayi / 10;
        }

        return kalanSayi == tersCevrilmisYari || kalanSayi == tersCevrilmisYari / 10;
    }
}
