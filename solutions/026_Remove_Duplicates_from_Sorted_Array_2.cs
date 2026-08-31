// 26 - Remove Duplicates from Sorted Array - Easy
// Task: Remove duplicate values from a sorted array in place and return the new logical length.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// Difficulty: Easy
// Question number: 26
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kume (HashSet) Yardimiyla Benzersizleri Toplama
// Zaman Karmasikligi: O(n) - dizi bir defa taranir
// Alan Karmasikligi: O(n) - benzersiz degerleri tutmak icin ek kume kullanilir
// Turkce aciklama: Dizi gezilirken her deger bir HashSet'e eklenir (sadece ilk gorulusu
// tutulur). Sonra bu benzersiz degerler sirali sekilde orijinal dizinin basina yazilir.

using System.Collections.Generic;

public class Solution
{
    public int RemoveDuplicates(int[] sayilar)
    {
        if (sayilar.Length == 0)
        {
            return 0;
        }

        var benzersizKume = new HashSet<int>();
        var benzersizListe = new List<int>();

        foreach (var sayi in sayilar)
        {
            if (benzersizKume.Add(sayi))
            {
                benzersizListe.Add(sayi);
            }
        }

        for (int indeks = 0; indeks < benzersizListe.Count; indeks++)
        {
            sayilar[indeks] = benzersizListe[indeks];
        }

        return benzersizListe.Count;
    }
}
