// 70 - Climbing Stairs - Easy
// Task: Count the number of distinct ways to climb n stairs when each move is one or two steps.
// Official link: https://leetcode.com/problems/climbing-stairs/
// Difficulty: Easy
// Question number: 70
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif DP, O(1) alan kullanarak (iki degisken ile)
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(1)
// Aciklama: Fibonacci benzeri iliski kullanilir: n. basamaga cikma yolu,
// (n-1). ve (n-2). basamaga cikma yollarinin toplamidir. Sadece son iki
// deger degiskenlerde tutularak ilerlenir.

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        int oncekiIkinci = 1;
        int oncekiBirinci = 2;

        for (int basamak = 3; basamak <= n; basamak++)
        {
            int guncelDeger = oncekiBirinci + oncekiIkinci;
            oncekiIkinci = oncekiBirinci;
            oncekiBirinci = guncelDeger;
        }

        return oncekiBirinci;
    }
}
