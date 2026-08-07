// 4 - Median of Two Sorted Arrays - Hard
// Task: Find the median value of two sorted arrays while keeping the required logarithmic time goal in mind.
// Official link: https://leetcode.com/problems/median-of-two-sorted-arrays/
// Difficulty: Hard
// Question number: 4
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ikili Arama (Binary Search) - kucuk diziyi esas alarak bolme noktasini ikili aramayla bul.
// Zaman Karmasikligi: O(log(min(m,n))) - ikili arama kucuk dizi uzerinde yapilir.
// Alan Karmasikligi: O(1) - ekstra dizi kullanilmaz.

using System;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] kucukDizi = nums1;
        int[] buyukDizi = nums2;

        if (kucukDizi.Length > buyukDizi.Length)
        {
            kucukDizi = nums2;
            buyukDizi = nums1;
        }

        int kucukUzunluk = kucukDizi.Length;
        int buyukUzunluk = buyukDizi.Length;
        int toplamYaris = (kucukUzunluk + buyukUzunluk + 1) / 2;

        int alt = 0;
        int ust = kucukUzunluk;

        while (alt <= ust)
        {
            int bolmeKucuk = (alt + ust) / 2;
            int bolmeBuyuk = toplamYaris - bolmeKucuk;

            int solKucukDeger = bolmeKucuk == 0 ? int.MinValue : kucukDizi[bolmeKucuk - 1];
            int sagKucukDeger = bolmeKucuk == kucukUzunluk ? int.MaxValue : kucukDizi[bolmeKucuk];

            int solBuyukDeger = bolmeBuyuk == 0 ? int.MinValue : buyukDizi[bolmeBuyuk - 1];
            int sagBuyukDeger = bolmeBuyuk == buyukUzunluk ? int.MaxValue : buyukDizi[bolmeBuyuk];

            if (solKucukDeger <= sagBuyukDeger && solBuyukDeger <= sagKucukDeger)
            {
                if ((kucukUzunluk + buyukUzunluk) % 2 == 0)
                {
                    int enBuyukSolDeger = Math.Max(solKucukDeger, solBuyukDeger);
                    int enKucukSagDeger = Math.Min(sagKucukDeger, sagBuyukDeger);
                    return (enBuyukSolDeger + enKucukSagDeger) / 2.0;
                }
                else
                {
                    return Math.Max(solKucukDeger, solBuyukDeger);
                }
            }
            else if (solKucukDeger > sagBuyukDeger)
            {
                ust = bolmeKucuk - 1;
            }
            else
            {
                alt = bolmeKucuk + 1;
            }
        }

        throw new ArgumentException("Girdi dizileri sirali degil.");
    }
}
