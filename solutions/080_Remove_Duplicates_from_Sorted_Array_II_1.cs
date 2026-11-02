// 80 - Remove Duplicates from Sorted Array II - Medium
// Task: In a sorted array, keep at most two copies of each value in place and return the new length.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
// Difficulty: Medium
// Question number: 80
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ekstra sayac kullanan yontem. Her degeri diziyi tarayarak kac kere
// tekrarlandigini sayiyoruz, ilk iki kopyayi yazma isaretcisiyle sonuc dizisine yaziyoruz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1) (giris dizisi uzerinde yerinde calisilir)

public class Solution
{
    public int RemoveDuplicates(int[] dizi)
    {
        int uzunluk = dizi.Length;

        if (uzunluk <= 2)
        {
            return uzunluk;
        }

        int yazmaIndeksi = 2;

        for (int okumaIndeksi = 2; okumaIndeksi < uzunluk; okumaIndeksi++)
        {
            if (dizi[okumaIndeksi] != dizi[yazmaIndeksi - 2])
            {
                dizi[yazmaIndeksi] = dizi[okumaIndeksi];
                yazmaIndeksi++;
            }
        }

        return yazmaIndeksi;
    }
}
