// 39 - Combination Sum - Medium
// Task: Find all combinations of candidate numbers that can sum to a target, allowing reuse of numbers.
// Official link: https://leetcode.com/problems/combination-sum/
// Difficulty: Medium
// Question number: 39
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Klasik Backtracking (tekrar kullanima izin veren)
// Her adimda mevcut indeksten baslayarak (geriye donmeden) bir sayiyi secip
// kalan hedeften cikariyoruz. Ayni sayi tekrar kullanilabildigi icin
// bir sonraki cagrida indeks ilerletmiyoruz.
// Zaman Karmasikligi: O(2^n) civarinda en kotu durumda (n aday sayisi)
// Alan Karmasikligi: O(target / min(candidates)) recursion derinligi icin

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> sonuclar = new List<IList<int>>();
        List<int> gecerliKombinasyon = new List<int>();

        BacktrackYap(candidates, target, 0, gecerliKombinasyon, sonuclar);

        return sonuclar;
    }

    private void BacktrackYap(int[] adaylar, int kalanHedef, int baslangicIndeksi,
        List<int> gecerliKombinasyon, IList<IList<int>> sonuclar)
    {
        if (kalanHedef == 0)
        {
            sonuclar.Add(new List<int>(gecerliKombinasyon));
            return;
        }

        if (kalanHedef < 0)
        {
            return;
        }

        for (int indeks = baslangicIndeksi; indeks < adaylar.Length; indeks++)
        {
            gecerliKombinasyon.Add(adaylar[indeks]);

            // Ayni sayiyi tekrar kullanabilmek icin indeks ilerletmiyoruz
            BacktrackYap(adaylar, kalanHedef - adaylar[indeks], indeks, gecerliKombinasyon, sonuclar);

            gecerliKombinasyon.RemoveAt(gecerliKombinasyon.Count - 1);
        }
    }
}
