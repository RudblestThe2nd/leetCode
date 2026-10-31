// 78 - Subsets - Medium
// Task: Return every subset of a list of distinct integers.
// Official link: https://leetcode.com/problems/subsets/
// Difficulty: Medium
// Question number: 78
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bit maskesi (iteratif) yontemi. 0 ile 2^n-1 arasindaki her sayi bir alt kumeyi
// temsil eder; sayinin bitleri hangi elemanlarin alt kumeye dahil oldugunu belirler.
// Zaman Karmasikligi: O(n * 2^n)
// Alan Karmasikligi: O(n) (gecici liste, sonuc haric)

using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Subsets(int[] dizi)
    {
        IList<IList<int>> sonuc = new List<IList<int>>();
        int uzunluk = dizi.Length;
        int toplamMaskeSayisi = 1 << uzunluk;

        for (int maske = 0; maske < toplamMaskeSayisi; maske++)
        {
            List<int> geciciListe = new List<int>();

            for (int bitIndeksi = 0; bitIndeksi < uzunluk; bitIndeksi++)
            {
                if ((maske & (1 << bitIndeksi)) != 0)
                {
                    geciciListe.Add(dizi[bitIndeksi]);
                }
            }

            sonuc.Add(geciciListe);
        }

        return sonuc;
    }
}
