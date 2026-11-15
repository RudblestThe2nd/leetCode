// 93 - Restore IP Addresses - Medium
// Task: Return all valid IP addresses that can be formed by inserting three dots into a digit string.
// Official link: https://leetcode.com/problems/restore-ip-addresses/
// Difficulty: Medium
// Question number: 93
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Backtracking (geri izleme) ile 4 parcaya bolme denemesi.
// Her adimda 1, 2 veya 3 karakter alip gecerli bir 0-255 parcasi olusturmaya calisir.
// Zaman Karmasikligi: O(3^4) - her parca icin en fazla 3 secenek, 4 parca var, sabit ust sinir.
// Alan Karmasikligi: O(uzunluk) - geri izleme yiginin derinligi ve gecici parca listesi icin.

using System.Collections.Generic;

public class Solution
{
    public IList<string> RestoreIpAddresses(string dizi)
    {
        var sonuc = new List<string>();
        var parcalar = new List<string>();

        GeriIzle(dizi, 0, parcalar, sonuc);

        return sonuc;
    }

    private void GeriIzle(string dizi, int indeks, List<string> parcalar, List<string> sonuc)
    {
        if (parcalar.Count == 4)
        {
            if (indeks == dizi.Length)
            {
                sonuc.Add(string.Join(".", parcalar));
            }

            return;
        }

        for (int uzunluk = 1; uzunluk <= 3 && indeks + uzunluk <= dizi.Length; uzunluk++)
        {
            string parca = dizi.Substring(indeks, uzunluk);

            if (!GecerliMi(parca))
            {
                continue;
            }

            parcalar.Add(parca);

            GeriIzle(dizi, indeks + uzunluk, parcalar, sonuc);

            parcalar.RemoveAt(parcalar.Count - 1);
        }
    }

    private bool GecerliMi(string parca)
    {
        if (parca.Length > 1 && parca[0] == '0')
        {
            return false;
        }

        int deger = int.Parse(parca);

        return deger >= 0 && deger <= 255;
    }
}
