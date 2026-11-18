// 96 - Unique Binary Search Trees - Medium
// Task: Count how many structurally unique binary search trees can be built with n distinct values.
// Official link: https://leetcode.com/problems/unique-binary-search-trees/
// Difficulty: Medium
// Question number: 96
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Katalan sayisi (Catalan number) formulunun dogrudan matematiksel hesaplanmasi.
// C(n) = (2n)! / ((n+1)! * n!) ifadesi, tasmayi engellemek icin adim adim carpma/bolme ile hesaplanir.
// Zaman Karmasikligi: O(n) - dongu bir kez n kadar donerek carpim/bolum uygulanir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public int NumTrees(int sayi)
    {
        long sonuc = 1;

        for (int i = 0; i < sayi; i++)
        {
            sonuc = sonuc * (2 * sayi - i) / (i + 2);
        }

        return (int)sonuc;
    }
}
