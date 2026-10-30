// 77 - Combinations - Medium
// Task: Return all size-k combinations chosen from numbers 1 through n.
// Official link: https://leetcode.com/problems/combinations/
// Difficulty: Medium
// Question number: 77
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Geriye izleme (backtracking). Her adimda mevcut sayidan baslayarak
// aday listeye eleman ekliyoruz, liste k boyutuna ulastiginda sonuca kopyaliyoruz,
// sonra son elemani cikarip (backtrack) baska secenekleri deniyoruz.
// Zaman Karmasikligi: O(k * C(n, k))
// Alan Karmasikligi: O(k) (yigin/gecici liste, sonuc haric)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Combine(int sayiSinir, int k)
    {
        IList<IList<int>> sonuc = new List<IList<int>>();
        List<int> geciciListe = new List<int>();

        GeriyeIzle(1, sayiSinir, k, geciciListe, sonuc);

        return sonuc;
    }

    private void GeriyeIzle(int baslangicSayisi, int sayiSinir, int k, List<int> geciciListe, IList<IList<int>> sonuc)
    {
        if (geciciListe.Count == k)
        {
            sonuc.Add(new List<int>(geciciListe));
            return;
        }

        for (int mevcutSayi = baslangicSayisi; mevcutSayi <= sayiSinir; mevcutSayi++)
        {
            geciciListe.Add(mevcutSayi);

            GeriyeIzle(mevcutSayi + 1, sayiSinir, k, geciciListe, sonuc);

            geciciListe.RemoveAt(geciciListe.Count - 1);
        }
    }
}
