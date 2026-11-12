// 90 - Subsets II - Medium
// Task: Return all unique subsets of an integer array that may contain duplicates.
// Official link: https://leetcode.com/problems/subsets-ii/
// Difficulty: Medium
// Question number: 90
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sirlama + geriye izleme (backtracking) ile ayni seviyede tekrarlari atlama
// Zaman Karmasikligi: O(2^n * n) - en fazla 2^n alt kume, her biri kopyalanirken O(n)
// Alan Karmasikligi: O(n) - ozyineleme derinligi ve gecici liste icin
// Aciklama: Diziyi once sirliyoruz. Geriye izleme sirasinda, ayni seviyede
// onceki elemanla ayni degeri tasiyan bir elemani secmezsek, tekrarli alt
// kumeler olusmasini engelleriz.
public class Solution
{
    private System.Collections.Generic.List<System.Collections.Generic.IList<int>> tumSonuclar =
        new System.Collections.Generic.List<System.Collections.Generic.IList<int>>();

    private System.Collections.Generic.List<int> geciciKume = new System.Collections.Generic.List<int>();

    public System.Collections.Generic.IList<System.Collections.Generic.IList<int>> SubsetsWithDup(int[] dizi)
    {
        System.Array.Sort(dizi);
        GeriyeIzle(dizi, 0);
        return tumSonuclar;
    }

    private void GeriyeIzle(int[] dizi, int baslangicIndeksi)
    {
        tumSonuclar.Add(new System.Collections.Generic.List<int>(geciciKume));

        for (int indeks = baslangicIndeksi; indeks < dizi.Length; indeks++)
        {
            if (indeks > baslangicIndeksi && dizi[indeks] == dizi[indeks - 1])
            {
                continue;
            }

            geciciKume.Add(dizi[indeks]);
            GeriyeIzle(dizi, indeks + 1);
            geciciKume.RemoveAt(geciciKume.Count - 1);
        }
    }
}
