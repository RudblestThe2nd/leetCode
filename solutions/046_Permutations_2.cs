// 46 - Permutations - Medium
// Task: Return all possible permutations of a list of distinct integers.
// Official link: https://leetcode.com/problems/permutations/
// Difficulty: Medium
// Question number: 46
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Yerinde Degistirme (Swap Based Backtracking)
// Ziyaret edildi dizisi kullanmadan, dizinin kendisi uzerinde eleman
// takasi yaparak permutasyonlari uretiriz. Her derinlikte, o konumdan
// sonraki her elemani sirayla o konuma tasiyip devam ederiz.
// Zaman Karmasikligi: O(dizi.Uzunluk * dizi.Uzunluk!)
// Alan Karmasikligi: O(dizi.Uzunluk) (cagri yigini haric)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Permute(int[] dizi)
    {
        IList<IList<int>> sonuclar = new List<IList<int>>();

        Takasla(dizi, 0, sonuclar);

        return sonuclar;
    }

    private void Takasla(int[] dizi, int derinlik, IList<IList<int>> sonuclar)
    {
        if (derinlik == dizi.Length)
        {
            List<int> gecici = new List<int>(dizi);
            sonuclar.Add(gecici);
            return;
        }

        for (int indeks = derinlik; indeks < dizi.Length; indeks++)
        {
            YerDegistir(dizi, derinlik, indeks);

            Takasla(dizi, derinlik + 1, sonuclar);

            YerDegistir(dizi, derinlik, indeks);
        }
    }

    private void YerDegistir(int[] dizi, int birinciKonum, int ikinciKonum)
    {
        int geciciDeger = dizi[birinciKonum];
        dizi[birinciKonum] = dizi[ikinciKonum];
        dizi[ikinciKonum] = geciciDeger;
    }
}
