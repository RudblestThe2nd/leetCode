// 57 - Insert Interval - Medium
// Task: Insert a new interval into a sorted interval list and merge overlaps.
// Official link: https://leetcode.com/problems/insert-interval/
// Difficulty: Medium
// Question number: 57
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Genel birlestirme mantigi - yeni aralik mevcut listeye eklenip
// tum liste baslangica gore siralanir, sonra klasik merge intervals uygulanir.
// Zaman Karmasikligi: O(n log n) - siralama islemi baskin maliyettir.
// Alan Karmasikligi: O(n) - siralanan liste ve sonuc icin kullanilan alan.

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[][] Insert(int[][] araliklar, int[] yeniAralik)
    {
        List<int[]> tumAraliklar = araliklar.ToList();
        tumAraliklar.Add(yeniAralik);

        List<int[]> siraliAraliklar = tumAraliklar.OrderBy(aralik => aralik[0]).ToList();
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
