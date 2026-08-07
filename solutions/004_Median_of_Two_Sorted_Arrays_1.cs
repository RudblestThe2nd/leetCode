// 4 - Median of Two Sorted Arrays - Hard
// Task: Find the median value of two sorted arrays while keeping the required logarithmic time goal in mind.
// Official link: https://leetcode.com/problems/median-of-two-sorted-arrays/
// Difficulty: Hard
// Question number: 4
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Birlestir ve Sirala (Merge) - iki diziyi tek bir sirali diziye birlestirip ortancayi bul.
// Zaman Karmasikligi: O(m+n) - iki dizinin birlestirilmesi.
// Alan Karmasikligi: O(m+n) - birlestirilmis yeni dizi icin.

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int uzunluk1 = nums1.Length;
        int uzunluk2 = nums2.Length;
        int toplamUzunluk = uzunluk1 + uzunluk2;

        int[] birlesikDizi = new int[toplamUzunluk];
        int indeks1 = 0;
        int indeks2 = 0;
        int indeks3 = 0;

        while (indeks1 < uzunluk1 && indeks2 < uzunluk2)
        {
            if (nums1[indeks1] <= nums2[indeks2])
            {
                birlesikDizi[indeks3] = nums1[indeks1];
                indeks1++;
            }
            else
            {
                birlesikDizi[indeks3] = nums2[indeks2];
                indeks2++;
            }
            indeks3++;
        }

        while (indeks1 < uzunluk1)
        {
            birlesikDizi[indeks3] = nums1[indeks1];
            indeks1++;
            indeks3++;
        }

        while (indeks2 < uzunluk2)
        {
            birlesikDizi[indeks3] = nums2[indeks2];
            indeks2++;
            indeks3++;
        }

        int ortaIndeks = toplamUzunluk / 2;

        if (toplamUzunluk % 2 == 0)
        {
            return (birlesikDizi[ortaIndeks - 1] + birlesikDizi[ortaIndeks]) / 2.0;
        }
        else
        {
            return birlesikDizi[ortaIndeks];
        }
    }
}
