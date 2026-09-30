// 55 - Jump Game - Medium
// Task: Determine whether the last index of an array can be reached using the jump lengths at each position.
// Official link: https://leetcode.com/problems/jump-game/
// Difficulty: Medium
// Question number: 55
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Greedy - her indekste erisilebilecek en uzak noktayi takip ederek
// son indekse ulasilip ulasilamayacagi belirlenir.
// Zaman Karmasikligi: O(n) - dizi bir kez taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public bool CanJump(int[] dizi)
    {
        int enUzakErisim = 0;

        for (int indeks = 0; indeks < dizi.Length; indeks++)
        {
            if (indeks > enUzakErisim)
            {
                return false;
            }

            enUzakErisim = Math.Max(enUzakErisim, indeks + dizi[indeks]);
        }

        return true;
    }
}
