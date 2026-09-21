// 46 - Permutations - Medium
// Task: Return all possible permutations of a list of distinct integers.
// Official link: https://leetcode.com/problems/permutations/
// Difficulty: Medium
// Question number: 46
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Backtracking (ziyaret edildi dizisi ile)
// Her adimda henuz kullanilmamis bir sayiyi gecici listeye ekleriz,
// listeyi uzunluk dizinin uzunluguna esit olana kadar derinlestiririz,
// sonra geri donup baska bir sayi deneriz.
// Zaman Karmasikligi: O(dizi.Uzunluk * dizi.Uzunluk!)
// Alan Karmasikligi: O(dizi.Uzunluk) (cagri yiginini haric, sonuc listesi haric)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Permute(int[] dizi)
    {
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

            ziyaretEdildi[indeks] = true;
            gecici.Add(dizi[indeks]);

            GeriDon(dizi, gecici, ziyaretEdildi, sonuclar);

            gecici.RemoveAt(gecici.Count - 1);
            ziyaretEdildi[indeks] = false;
        }
    }
}
