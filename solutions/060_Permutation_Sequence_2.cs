// 60 - Permutation Sequence - Hard
// Task: Return the kth permutation sequence of the numbers 1 through n.
// Official link: https://leetcode.com/problems/permutation-sequence/
// Difficulty: Hard
// Question number: 60
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Backtracking ile tum permutasyonlari uretip k. sirada olani bulma.
// n kisitli (n<=9) oldugu icin toplam permutasyon sayisi guvenli sinirlar icindedir.
// Zaman Karmasikligi: O(n!) - tum permutasyonlar tek tek uretilir.
// Alan Karmasikligi: O(n) - kullanilan rakamlar ve gecici dizi icin.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    private int sayac = 0;
    private string sonuc = null;

    public string GetPermutation(int n, int k)
    {
        List<int> rakamlar = new List<int>();

        for (int sayi = 1; sayi <= n; sayi++)
        {
            rakamlar.Add(sayi);
        }

        bool[] kullanildi = new bool[n + 1];
        StringBuilder gecici = new StringBuilder();

        GeriTakip(rakamlar, kullanildi, gecici, n, k);

        return sonuc;
    }

    private void GeriTakip(List<int> rakamlar, bool[] kullanildi, StringBuilder gecici, int n, int k)
    {
        if (sonuc != null)
        {
            return;
        }

        if (gecici.Length == n)
        {
            sayac++;

            if (sayac == k)
            {
                sonuc = gecici.ToString();
            }

            return;
        }

        foreach (int rakam in rakamlar)
        {
            if (kullanildi[rakam])
            {
                continue;
            }

            kullanildi[rakam] = true;
            gecici.Append(rakam);

            GeriTakip(rakamlar, kullanildi, gecici, n, k);

            gecici.Length--;
            kullanildi[rakam] = false;

            if (sonuc != null)
            {
                return;
            }
        }
    }
}
