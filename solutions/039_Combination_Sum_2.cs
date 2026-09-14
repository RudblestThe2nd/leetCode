// 39 - Combination Sum - Medium
// Task: Find all combinations of candidate numbers that can sum to a target, allowing reuse of numbers.
// Official link: https://leetcode.com/problems/combination-sum/
// Difficulty: Medium
// Question number: 39
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Backtracking + Siralama ile Erken Durdurma (Pruning)
// Adaylari once kucukten buyuge siraliyoruz. Bu sayede bir aday kalan hedeften
// buyukse, sondan sonraki tum adaylar da buyuk olacagindan donguyu erken kirabiliyoruz.
// Bu, bos denemelerin onune gecerek performansi artirir.
// Zaman Karmasikligi: O(2^n) en kotu durumda, ama pruning sayesinde pratikte daha hizli
// Alan Karmasikligi: O(target / min(candidates)) recursion derinligi icin

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
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
            // Dizi sirali oldugu icin, mevcut aday hedefi asiyorsa sonrakiler de asar
            if (siraliAdaylar[indeks] > kalanHedef)
            {
                break;
            }

            gecerliKombinasyon.Add(siraliAdaylar[indeks]);

            BacktrackYap(siraliAdaylar, kalanHedef - siraliAdaylar[indeks], indeks, gecerliKombinasyon, sonuclar);

            gecerliKombinasyon.RemoveAt(gecerliKombinasyon.Count - 1);
        }
    }
}
