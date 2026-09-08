// 34 - Find First and Last Position of Element in Sorted Array - Medium
// Task: Find the first and last index of a target value in a sorted array.
// Official link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
// Difficulty: Medium
// Question number: 34
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Binary Search ile sol ve sag sinirlarini ayri ayri bulma
// Once hedefin ilk gorulme indeksini binary search ile bulan bir yardimci metot,
// sonra son gorulme indeksini bulan baska bir yardimci metot cagiriyoruz.
// Zaman Karmasikligi: O(log n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int ilkIndeks = SiniriBul(nums, target, true);

        if (ilkIndeks == -1)
        {
            return new int[] { -1, -1 };
        }

        int sonIndeks = SiniriBul(nums, target, false);

        return new int[] { ilkIndeks, sonIndeks };
    }

    private int SiniriBul(int[] dizi, int hedef, bool ilkSinirMi)
    {
        int sol = 0;
        int sag = dizi.Length - 1;
        int sonuc = -1;

        while (sol <= sag)
        {
            int orta = sol + (sag - sol) / 2;

            if (dizi[orta] == hedef)
            {
                sonuc = orta;

                if (ilkSinirMi)
                {
                    // Daha sola dogru aramaya devam et
                    sag = orta - 1;
                }
                else
                {
                    // Daha saga dogru aramaya devam et
                    sol = orta + 1;
                }
            }
            else if (dizi[orta] < hedef)
            {
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return sonuc;
    }
}
