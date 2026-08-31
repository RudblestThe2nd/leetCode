// 27 - Remove Element - Easy
// Task: Remove every occurrence of a given value from an array in place and return the new logical length.
// Official link: https://leetcode.com/problems/remove-element/
// Difficulty: Easy
// Question number: 27
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki Isaretci - Sirayi Koruyan Yazma
// Zaman Karmasikligi: O(n) - dizi bir defa taranir
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz
// Turkce aciklama: Yazma pozisyonunu tutan bir isaretci ile dizi bastan sona taranir.
// Silinecek degere denk gelmeyen her eleman, sirasi korunarak yazma pozisyonuna kopyalanir.

public class Solution
{
    public int RemoveElement(int[] sayilar, int deger)
    {
        int yazmaIndeksi = 0;

        for (int okumaIndeksi = 0; okumaIndeksi < sayilar.Length; okumaIndeksi++)
        {
            if (sayilar[okumaIndeksi] != deger)
            {
                sayilar[yazmaIndeksi] = sayilar[okumaIndeksi];
                yazmaIndeksi++;
            }
        }

        return yazmaIndeksi;
    }
}
