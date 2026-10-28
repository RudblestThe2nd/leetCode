// 75 - Sort Colors - Medium
// Task: Sort an array containing only 0, 1, and 2 in place.
// Official link: https://leetcode.com/problems/sort-colors/
// Difficulty: Medium
// Question number: 75
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sayma sirali (counting sort) yontemi. Once 0, 1 ve 2 degerlerinin
// kac kere gectigini sayiyoruz, ardindan diziyi bu sayimlara gore yeniden yaziyoruz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1)

public class Solution
{
    public void SortColors(int[] dizi)
    {
        int uzunluk = dizi.Length;

        int sifirSayaci = 0;
        int birSayaci = 0;
        int ikiSayaci = 0;

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            if (dizi[indeks] == 0)
            {
                sifirSayaci++;
            }
            else if (dizi[indeks] == 1)
            {
                birSayaci++;
            }
            else
            {
                ikiSayaci++;
            }
        }

        int yazmaIndeksi = 0;

        for (int sayac = 0; sayac < sifirSayaci; sayac++)
        {
            dizi[yazmaIndeksi] = 0;
            yazmaIndeksi++;
        }

        for (int sayac = 0; sayac < birSayaci; sayac++)
        {
            dizi[yazmaIndeksi] = 1;
            yazmaIndeksi++;
        }

        for (int sayac = 0; sayac < ikiSayaci; sayac++)
        {
            dizi[yazmaIndeksi] = 2;
            yazmaIndeksi++;
        }
    }
}
