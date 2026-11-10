// 88 - Merge Sorted Array - Easy
// Task: Merge two sorted arrays into the first array in nondecreasing order.
// Official link: https://leetcode.com/problems/merge-sorted-array/
// Difficulty: Easy
// Question number: 88
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sondan basa dogru iki isaretci ile yerinde (in-place) birlestirme
// Zaman Karmasikligi: O(m + n) - her iki dizi bir kez taranir
// Alan Karmasikligi: O(1) - ek dizi kullanilmadan yerinde calisir
// Aciklama: Her iki dizinin de gecerli elemanlarinin en sonundan baslayarak,
// buyuk olan degeri birinci dizinin en sonuna yerlestiriyoruz. Bu sayede
// henuz kullanilmamis kisimlarin uzerine yazmadan geriye dogru ilerleriz.
public class Solution
{
    public void Merge(int[] dizi1, int uzunluk1, int[] dizi2, int uzunluk2)
    {
        int indeks1 = uzunluk1 - 1;
        int indeks2 = uzunluk2 - 1;
        int yazmaIndeksi = uzunluk1 + uzunluk2 - 1;

        while (indeks2 >= 0)
        {
            if (indeks1 >= 0 && dizi1[indeks1] > dizi2[indeks2])
            {
                dizi1[yazmaIndeksi] = dizi1[indeks1];
                indeks1--;
            }
            else
            {
                dizi1[yazmaIndeksi] = dizi2[indeks2];
                indeks2--;
            }

            yazmaIndeksi--;
        }
    }
}
