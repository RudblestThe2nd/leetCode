// 40 - Combination Sum II - Medium
// Task: Find all unique combinations that sum to a target when each candidate can be used at most once.
// Official link: https://leetcode.com/problems/combination-sum-ii/
// Difficulty: Medium
// Question number: 40
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Backtracking + Siralama + Duplicate Atlama (klasik yontem)
// Adaylari sirala, her seviyede ayni degeri birden fazla kez secmemek icin
// ayni indekste ayni degeri gorursek atla. Her aday en fazla bir kez kullanilir.
// Zaman Karmasikligi: O(2^n) en kotu durumda
// Alan Karmasikligi: O(n) recursion derinligi icin

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        IList<IList<int>> sonuclar = new List<IList<int>>();
        List<int> gecerliKombinasyon = new List<int>();

        BacktrackYap(candidates, target, 0, gecerliKombinasyon, sonuclar);

        return sonuclar;
    }

    private void BacktrackYap(int[] siraliAdaylar, int kalanHedef, int baslangicIndeksi,
        List<int> gecerliKombinasyon, IList<IList<int>> sonuclar)
    {
        if (kalanHedef == 0)
        {
            sonuclar.Add(new List<int>(gecerliKombinasyon));
            return;
        }

        for (int indeks = baslangicIndeksi; indeks < siraliAdaylar.Length; indeks++)
        {
            // Ayni seviyede ayni degeri tekrar secmekten kacin (duplicate kombinasyon onleme)
            if (indeks > baslangicIndeksi && siraliAdaylar[indeks] == siraliAdaylar[indeks - 1])
            {
                continue;
            }

            if (siraliAdaylar[indeks] > kalanHedef)
            {
                break;
            }

            gecerliKombinasyon.Add(siraliAdaylar[indeks]);

            // Her aday en fazla bir kez kullanilabildigi icin bir sonraki indeksten basliyoruz
            BacktrackYap(siraliAdaylar, kalanHedef - siraliAdaylar[indeks], indeks + 1, gecerliKombinasyon, sonuclar);

            gecerliKombinasyon.RemoveAt(gecerliKombinasyon.Count - 1);
        }
    }
}
