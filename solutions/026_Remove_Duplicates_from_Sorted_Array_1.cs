// 26 - Remove Duplicates from Sorted Array - Easy
// Task: Remove duplicate values from a sorted array in place and return the new logical length.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// Difficulty: Easy
// Question number: 26
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki Isaretci (Two-Pointer) - Yerinde (In-place)
// Zaman Karmasikligi: O(n) - dizi bir defa taranir
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz
// Turkce aciklama: Yazma pozisyonunu tutan bir isaretci ile dizi taranir. Suanki eleman
// onceki benzersiz elemandan farkliysa yazma pozisyonuna kopyalanir ve isaretci ilerletilir.

public class Solution
{
    public int RemoveDuplicates(int[] sayilar)
    {
        if (sayilar.Length == 0)
        {
            return 0;
        }

        int yazmaIndeksi = 1;

        for (int okumaIndeksi = 1; okumaIndeksi < sayilar.Length; okumaIndeksi++)
        {
            if (sayilar[okumaIndeksi] != sayilar[yazmaIndeksi - 1])
            {
                sayilar[yazmaIndeksi] = sayilar[okumaIndeksi];
                yazmaIndeksi++;
            }
        }

        return yazmaIndeksi;
    }
}
