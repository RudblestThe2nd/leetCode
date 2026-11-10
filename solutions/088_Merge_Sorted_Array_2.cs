// 88 - Merge Sorted Array - Easy
// Task: Merge two sorted arrays into the first array in nondecreasing order.
// Official link: https://leetcode.com/problems/merge-sorted-array/
// Difficulty: Easy
// Question number: 88
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Gecici yardimci dizi olusturup bastan basa iki isaretci ile birlestirme
// Zaman Karmasikligi: O(m + n) - her iki dizi bir kez taranir
// Alan Karmasikligi: O(m + n) - gecici birlestirme dizisi icin
// Aciklama: Birinci dizinin gecerli kismini gecici bir diziye kopyaliyoruz,
// sonra bu gecici dizi ile ikinci diziyi kucukten buyuge karsilastirarak
// sirayla asil diziye geri yaziyoruz.
public class Solution
{
    public void Merge(int[] dizi1, int uzunluk1, int[] dizi2, int uzunluk2)
    {
        int[] geciciDizi = new int[uzunluk1];
        for (int indeks = 0; indeks < uzunluk1; indeks++)
        {
            geciciDizi[indeks] = dizi1[indeks];
        }

        int indeksGecici = 0;
        int indeksIkinci = 0;
        int yazmaIndeksi = 0;

        while (indeksGecici < uzunluk1 && indeksIkinci < uzunluk2)
        {
            if (geciciDizi[indeksGecici] <= dizi2[indeksIkinci])
            {
                dizi1[yazmaIndeksi] = geciciDizi[indeksGecici];
                indeksGecici++;
            }
            else
            {
                dizi1[yazmaIndeksi] = dizi2[indeksIkinci];
                indeksIkinci++;
            }

            yazmaIndeksi++;
        }

        while (indeksGecici < uzunluk1)
        {
            dizi1[yazmaIndeksi] = geciciDizi[indeksGecici];
            indeksGecici++;
            yazmaIndeksi++;
        }

        while (indeksIkinci < uzunluk2)
        {
            dizi1[yazmaIndeksi] = dizi2[indeksIkinci];
            indeksIkinci++;
            yazmaIndeksi++;
        }
    }
}
