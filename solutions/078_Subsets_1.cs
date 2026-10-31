// 78 - Subsets - Medium
// Task: Return every subset of a list of distinct integers.
// Official link: https://leetcode.com/problems/subsets/
// Difficulty: Medium
// Question number: 78
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Geriye izleme (backtracking). Her eleman icin "dahil et / dahil etme"
// karari verilerek tum alt kumeler uretilir. Her adimda gecici listeyi sonuca kopyaliyoruz.
// Zaman Karmasikligi: O(n * 2^n)
// Alan Karmasikligi: O(n) (yigin/gecici liste, sonuc haric)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Subsets(int[] dizi)
    {
        IList<IList<int>> sonuc = new List<IList<int>>();
        List<int> geciciListe = new List<int>();

        GeriyeIzle(0, dizi, geciciListe, sonuc);

        return sonuc;
    }

    private void GeriyeIzle(int baslangicIndeksi, int[] dizi, List<int> geciciListe, IList<IList<int>> sonuc)
    {
        sonuc.Add(new List<int>(geciciListe));

        for (int indeks = baslangicIndeksi; indeks < dizi.Length; indeks++)
        {
            geciciListe.Add(dizi[indeks]);

            GeriyeIzle(indeks + 1, dizi, geciciListe, sonuc);

            geciciListe.RemoveAt(geciciListe.Count - 1);
        }
    }
}
