// 70 - Climbing Stairs - Easy
// Task: Count the number of distinct ways to climb n stairs when each move is one or two steps.
// Official link: https://leetcode.com/problems/climbing-stairs/
// Difficulty: Easy
// Question number: 70
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) fonksiyon + memoization (hatirlama)
// Zaman Karmasikligi: O(n) - her alt problem sadece bir kez hesaplanir
// Alan Karmasikligi: O(n) - hatirlama sozlugu ve ozyineleme yigini icin
// Aciklama: Fonksiyon kendi kendini cagirir: f(n) = f(n-1) + f(n-2). Daha once
// hesaplanan sonuclar bir sozlukte saklanir, boylece ayni alt problem tekrar
// tekrar cozulmez.

using System.Collections.Generic;

public class Solution
{
    private Dictionary<int, int> hatirlamaSozlugu = new Dictionary<int, int>();

    public int ClimbStairs(int n)
    {
        return YoluHesapla(n);
    }

    private int YoluHesapla(int basamakSayisi)
    {
        if (basamakSayisi <= 2)
        {
            return basamakSayisi;
        }

        if (hatirlamaSozlugu.ContainsKey(basamakSayisi))
        {
            return hatirlamaSozlugu[basamakSayisi];
        }

        int sonuc = YoluHesapla(basamakSayisi - 1) + YoluHesapla(basamakSayisi - 2);
        hatirlamaSozlugu[basamakSayisi] = sonuc;

        return sonuc;
    }
}
