// 55 - Jump Game - Medium
// Task: Determine whether the last index of an array can be reached using the jump lengths at each position.
// Official link: https://leetcode.com/problems/jump-game/
// Difficulty: Medium
// Question number: 55
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Dinamik Programlama - her indeksin erisilebilir olup olmadigi
// sondan basa dogru bir bool dizisi ile hesaplanir.
// Zaman Karmasikligi: O(n^2) - her indeks icin en fazla n adimlik kontrol yapilir.
// Alan Karmasikligi: O(n) - erisilebilirlik durumunu tutan dizi kullanilir.

public class Solution
{
    public bool CanJump(int[] dizi)
    {
        int uzunluk = dizi.Length;
        bool[] erisilebilir = new bool[uzunluk];
        erisilebilir[uzunluk - 1] = true;

        for (int indeks = uzunluk - 2; indeks >= 0; indeks--)
        {
            int maksimumAdim = Math.Min(dizi[indeks], uzunluk - 1 - indeks);

            for (int adim = 1; adim <= maksimumAdim; adim++)
            {
                if (erisilebilir[indeks + adim])
                {
                    erisilebilir[indeks] = true;
                    break;
                }
            }
        }

        return erisilebilir[0];
    }
}
