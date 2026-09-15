// 40 - Combination Sum II - Medium
// Task: Find all unique combinations that sum to a target when each candidate can be used at most once.
// Official link: https://leetcode.com/problems/combination-sum-ii/
// Difficulty: Medium
// Question number: 40
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Sayim Tabanli (Dictionary/HashMap) Backtracking
// Adaylari deger -> tekrar sayisi seklinde bir Dictionary'de gruplayip
// benzersiz degerlerin listesi uzerinde backtracking yapiyoruz. Her benzersiz
// degerden 0 ile mevcut tekrar sayisi arasinda kac tane kullanilacagini deniyoruz.
// Bu, duplicate kombinasyonlari dogal olarak onler cunku ayni deger bir kez ele alinir.
// Zaman Karmasikligi: O(2^benzersizSayi * benzersizSayi) civarinda en kotu durumda
// Alan Karmasikligi: O(benzersizSayi) yardimci veri yapilari icin

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Dictionary<int, int> tekrarSayilari = new Dictionary<int, int>();

        foreach (int deger in candidates)
        {
            if (tekrarSayilari.ContainsKey(deger))
            {
                tekrarSayilari[deger]++;
            }
            else
            {
                tekrarSayilari[deger] = 1;
            }
        }

        List<int> benzersizDegerler = new List<int>(tekrarSayilari.Keys);
        benzersizDegerler.Sort();

        IList<IList<int>> sonuclar = new List<IList<int>>();
        List<int> gecerliKombinasyon = new List<int>();

        BacktrackYap(benzersizDegerler, tekrarSayilari, target, 0, gecerliKombinasyon, sonuclar);

        return sonuclar;
    }

    private void BacktrackYap(List<int> benzersizDegerler, Dictionary<int, int> tekrarSayilari,
        int kalanHedef, int baslangicIndeksi, List<int> gecerliKombinasyon, IList<IList<int>> sonuclar)
    {
        if (kalanHedef == 0)
        {
            sonuclar.Add(new List<int>(gecerliKombinasyon));
            return;
        }

        if (baslangicIndeksi >= benzersizDegerler.Count)
        {
            return;
        }

        for (int indeks = baslangicIndeksi; indeks < benzersizDegerler.Count; indeks++)
        {
            int deger = benzersizDegerler[indeks];

            if (deger > kalanHedef)
            {
                break;
            }

            int maksimumKullanim = Math.Min(tekrarSayilari[deger], kalanHedef / deger);

            for (int kullanimSayisi = 1; kullanimSayisi <= maksimumKullanim; kullanimSayisi++)
            {
                for (int tekrar = 0; tekrar < kullanimSayisi; tekrar++)
                {
                    gecerliKombinasyon.Add(deger);
                }

                BacktrackYap(benzersizDegerler, tekrarSayilari, kalanHedef - deger * kullanimSayisi,
                    indeks + 1, gecerliKombinasyon, sonuclar);

                for (int tekrar = 0; tekrar < kullanimSayisi; tekrar++)
                {
                    gecerliKombinasyon.RemoveAt(gecerliKombinasyon.Count - 1);
                }
            }
        }
    }
}
