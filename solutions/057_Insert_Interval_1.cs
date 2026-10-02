// 57 - Insert Interval - Medium
// Task: Insert a new interval into a sorted interval list and merge overlaps.
// Official link: https://leetcode.com/problems/insert-interval/
// Difficulty: Medium
// Question number: 57
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Uc bolgeye ayirma - yeni araliktan once bitenler, yeni aralikla
// cakisanlar (birlestirilerek) ve yeni araliktan sonra baslayanlar tek gecis ile eklenir.
// Zaman Karmasikligi: O(n) - aralik listesi bir kez taranir.
// Alan Karmasikligi: O(n) - sonuc listesi icin kullanilan alan.

using System.Collections.Generic;

public class Solution
{
    public int[][] Insert(int[][] araliklar, int[] yeniAralik)
    {
        List<int[]> sonuc = new List<int[]>();
        int indeks = 0;
        int uzunluk = araliklar.Length;

        while (indeks < uzunluk && araliklar[indeks][1] < yeniAralik[0])
        {
            sonuc.Add(araliklar[indeks]);
            indeks++;
        }

        int birlesikBaslangic = yeniAralik[0];
        int birlesikBitis = yeniAralik[1];

        while (indeks < uzunluk && araliklar[indeks][0] <= birlesikBitis)
        {
            birlesikBaslangic = Math.Min(birlesikBaslangic, araliklar[indeks][0]);
            birlesikBitis = Math.Max(birlesikBitis, araliklar[indeks][1]);
            indeks++;
        }

        sonuc.Add(new int[] { birlesikBaslangic, birlesikBitis });

        while (indeks < uzunluk)
        {
            sonuc.Add(araliklar[indeks]);
            indeks++;
        }

        return sonuc.ToArray();
    }
}
