// 77 - Combinations - Medium
// Task: Return all size-k combinations chosen from numbers 1 through n.
// Official link: https://leetcode.com/problems/combinations/
// Difficulty: Medium
// Question number: 77
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yinelemeli (iteratif) yontem. 1..k araligindaki baslangic kombinasyonundan
// baslayip, her adimda kombinasyonu "bir sonraki" kombinasyona tasiyarak (sagdan sola
// tasma kontrolu ile) tum kombinasyonlari sirayla uretiyoruz.
// Zaman Karmasikligi: O(k * C(n, k))
// Alan Karmasikligi: O(k)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Combine(int sayiSinir, int k)
    {
        IList<IList<int>> sonuc = new List<IList<int>>();

        if (k > sayiSinir || k <= 0)
        {
            return sonuc;
        }

        int[] mevcutKombinasyon = new int[k];

        for (int indeks = 0; indeks < k; indeks++)
        {
            mevcutKombinasyon[indeks] = indeks + 1;
        }

        while (true)
        {
            List<int> kopya = new List<int>();

            for (int indeks = 0; indeks < k; indeks++)
            {
                kopya.Add(mevcutKombinasyon[indeks]);
            }

            sonuc.Add(kopya);

            int degisecekIndeks = k - 1;

            while (degisecekIndeks >= 0 && mevcutKombinasyon[degisecekIndeks] == sayiSinir - (k - 1 - degisecekIndeks))
            {
                degisecekIndeks--;
            }

            if (degisecekIndeks < 0)
            {
                break;
            }

            mevcutKombinasyon[degisecekIndeks]++;

            for (int sonrakiIndeks = degisecekIndeks + 1; sonrakiIndeks < k; sonrakiIndeks++)
            {
                mevcutKombinasyon[sonrakiIndeks] = mevcutKombinasyon[sonrakiIndeks - 1] + 1;
            }
        }

        return sonuc;
    }
}
