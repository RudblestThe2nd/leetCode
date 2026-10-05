// 60 - Permutation Sequence - Hard
// Task: Return the kth permutation sequence of the numbers 1 through n.
// Official link: https://leetcode.com/problems/permutation-sequence/
// Difficulty: Hard
// Question number: 60
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Faktoriyel sayi sistemi - her adimda (n-1)! ile bolerek hangi
// rakamin secilecegi matematiksel olarak belirlenir, secilen rakam listeden cikarilir.
// Zaman Karmasikligi: O(n^2) - her adimda listeden eleman cikarma O(n) surer, n adim vardir.
// Alan Karmasikligi: O(n) - kullanilabilir rakamlari tutan liste icin.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string GetPermutation(int n, int k)
    {
        List<int> rakamlar = new List<int>();
        int[] faktoriyeller = new int[n + 1];
        faktoriyeller[0] = 1;

        for (int sayi = 1; sayi <= n; sayi++)
        {
            faktoriyeller[sayi] = faktoriyeller[sayi - 1] * sayi;
            rakamlar.Add(sayi);
        }

        StringBuilder sonuc = new StringBuilder();
        int kalan = k - 1;

        for (int adim = n; adim >= 1; adim--)
        {
            int boyut = faktoriyeller[adim - 1];
            int indeks = kalan / boyut;
            kalan = kalan % boyut;

            sonuc.Append(rakamlar[indeks]);
            rakamlar.RemoveAt(indeks);
        }

        return sonuc.ToString();
    }
}
