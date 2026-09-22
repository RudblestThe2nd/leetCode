// 47 - Permutations II - Medium
// Task: Return all unique permutations of a list that may contain duplicate integers.
// Official link: https://leetcode.com/problems/permutations-ii/
// Difficulty: Medium
// Question number: 47
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Siralama + Backtracking + Tekrar Budama (Duplicate Pruning)
// Once diziyi sirala, boylece esit degerler yan yana durur. Ayni derinlikte,
// bir onceki esit deger henuz kullanilmadiysa (ziyaretEdildi[i-1] == false),
// bu deger atlanir. Bu, ayni permutasyonun tekrar uretilmesini onler.
// Zaman Karmasikligi: O(dizi.Uzunluk * dizi.Uzunluk!)
// Alan Karmasikligi: O(dizi.Uzunluk)

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] dizi)
    {
        Array.Sort(dizi);

        IList<IList<int>> sonuclar = new List<IList<int>>();

        List<int> gecici = new List<int>();

        bool[] ziyaretEdildi = new bool[dizi.Length];

        GeriDon(dizi, gecici, ziyaretEdildi, sonuclar);

        return sonuclar;
    }

    private void GeriDon(int[] dizi, List<int> gecici, bool[] ziyaretEdildi, IList<IList<int>> sonuclar)
    {
        if (gecici.Count == dizi.Length)
        {
            sonuclar.Add(new List<int>(gecici));
            return;
        }

        for (int indeks = 0; indeks < dizi.Length; indeks++)
        {
            if (ziyaretEdildi[indeks])
            {
                continue;
            }

            bool oncekiAyniVeKullanilmamis =
                indeks > 0 && dizi[indeks] == dizi[indeks - 1] && !ziyaretEdildi[indeks - 1];

            if (oncekiAyniVeKullanilmamis)
            {
                continue;
            }

            ziyaretEdildi[indeks] = true;
            gecici.Add(dizi[indeks]);

            GeriDon(dizi, gecici, ziyaretEdildi, sonuclar);

            gecici.RemoveAt(gecici.Count - 1);
            ziyaretEdildi[indeks] = false;
        }
    }
}
