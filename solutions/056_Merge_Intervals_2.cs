// 56 - Merge Intervals - Medium
// Task: Merge all overlapping intervals and return the resulting non-overlapping intervals.
// Official link: https://leetcode.com/problems/merge-intervals/
// Difficulty: Medium
// Question number: 56
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Siraladiktan sonra bir Stack<int[]> kullanarak zirvedeki aralikla
// yeni aralik cakisiyorsa zirvedekini guncelleme, aksi halde yeni pushlama.
// Zaman Karmasikligi: O(n log n) - siralama islemi baskin maliyettir.
// Alan Karmasikligi: O(n) - yigin ve sonuc icin kullanilan alan.

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[][] Merge(int[][] araliklar)
    {
        if (araliklar == null || araliklar.Length == 0)
        {
            return araliklar;
        }

        int[][] siraliAraliklar = araliklar.OrderBy(aralik => aralik[0]).ToArray();
        Stack<int[]> yigin = new Stack<int[]>();

        foreach (int[] aralik in siraliAraliklar)
        {
            if (yigin.Count == 0)
            {
                yigin.Push(aralik);
                continue;
            }

            int[] zirvedeki = yigin.Peek();

            if (aralik[0] <= zirvedeki[1])
            {
                zirvedeki[1] = Math.Max(zirvedeki[1], aralik[1]);
            }
            else
            {
                yigin.Push(aralik);
            }
        }

        int[][] sonuc = yigin.ToArray();
        Array.Reverse(sonuc);
        return sonuc;
    }
}
