// 80 - Remove Duplicates from Sorted Array II - Medium
// Task: In a sorted array, keep at most two copies of each value in place and return the new length.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
// Difficulty: Medium
// Question number: 80
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ayni deger tekrar sayacini elle takip eden yontem. Onceki degerle
// karsilastirarak bir sayac tutuyoruz; sayac 2'yi gectiginde eleman atlaniyor,
// aksi halde yazma isaretcisine kopyalaniyor.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int RemoveDuplicates(int[] dizi)
    {
        int uzunluk = dizi.Length;

        if (uzunluk == 0)
        {
            return 0;
        }

        int yazmaIndeksi = 1;
        int tekrarSayaci = 1;

        for (int okumaIndeksi = 1; okumaIndeksi < uzunluk; okumaIndeksi++)
        {
            if (dizi[okumaIndeksi] == dizi[okumaIndeksi - 1])
            {
                tekrarSayaci++;
            }
            else
            {
                tekrarSayaci = 1;
            }

            if (tekrarSayaci <= 2)
            {
                dizi[yazmaIndeksi] = dizi[okumaIndeksi];
                yazmaIndeksi++;
            }
        }

        return yazmaIndeksi;
    }
}
