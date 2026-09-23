// 47 - Permutations II - Medium
// Task: Return all unique permutations of a list that may contain duplicate integers.
// Official link: https://leetcode.com/problems/permutations-ii/
// Difficulty: Medium
// Question number: 47
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Sayac Haritasi ile Backtracking (Frequency Map)
// Her benzersiz deger icin kalan kullanim sayisini bir haritada tutariz.
// Her derinlikte, sayaci sifirdan buyuk olan her benzersiz degeri bir kez
// deneriz. Boylece siralama gerekmez ve dogal olarak tekrarlar onlenir.
// Zaman Karmasikligi: O(dizi.Uzunluk * dizi.Uzunluk!)
// Alan Karmasikligi: O(dizi.Uzunluk)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] dizi)
    {
        IList<IList<int>> sonuclar = new List<IList<int>>();

        Dictionary<int, int> sayacHaritasi = new Dictionary<int, int>();

        foreach (int deger in dizi)
        {
            if (sayacHaritasi.ContainsKey(deger))
            {
                sayacHaritasi[deger]++;
            }
            else
            {
                sayacHaritasi[deger] = 1;
            }
        }

        List<int> gecici = new List<int>();

        GeriDon(dizi.Length, sayacHaritasi, gecici, sonuclar);

        return sonuclar;
    }

    private void GeriDon(int hedefUzunluk, Dictionary<int, int> sayacHaritasi, List<int> gecici, IList<IList<int>> sonuclar)
    {
        if (gecici.Count == hedefUzunluk)
        {
            sonuclar.Add(new List<int>(gecici));
            return;
        }

        List<int> anahtarlar = new List<int>(sayacHaritasi.Keys);

        foreach (int anahtar in anahtarlar)
        {
            if (sayacHaritasi[anahtar] <= 0)
            {
                continue;
            }

            sayacHaritasi[anahtar]--;
            gecici.Add(anahtar);

            GeriDon(hedefUzunluk, sayacHaritasi, gecici, sonuclar);

            gecici.RemoveAt(gecici.Count - 1);
            sayacHaritasi[anahtar]++;
        }
    }
}
