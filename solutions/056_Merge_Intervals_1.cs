// 56 - Merge Intervals - Medium
// Task: Merge all overlapping intervals and return the resulting non-overlapping intervals.
// Official link: https://leetcode.com/problems/merge-intervals/
// Difficulty: Medium
// Question number: 56
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Baslangic degerine gore sirala, ardindan tek gecisle List<int[]>
// icinde son eklenen aralikla cakisma kontrolu yapip birlestirme uygula.
// Zaman Karmasikligi: O(n log n) - siralama islemi baskin maliyettir.
// Alan Karmasikligi: O(n) - sonuc listesi ve siralama icin kullanilan alan.

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
        List<int[]> sonuc = new List<int[]>();

        foreach (int[] aralik in siraliAraliklar)
        {
            if (sonuc.Count == 0)
            {
                sonuc.Add(aralik);
                continue;
            }

            int[] sonEklenen = sonuc[sonuc.Count - 1];

            if (aralik[0] <= sonEklenen[1])
            {
                sonEklenen[1] = Math.Max(sonEklenen[1], aralik[1]);
            }
            else
            {
                sonuc.Add(aralik);
            }
        }

        return sonuc.ToArray();
    }
}
