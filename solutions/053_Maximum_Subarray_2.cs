// 53 - Maximum Subarray - Medium
// Task: Find the contiguous subarray with the largest possible sum.
// Official link: https://leetcode.com/problems/maximum-subarray/
// Difficulty: Medium
// Question number: 53
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kadane Algoritmasi - her adimda mevcut toplami guncelleyip
// negatif oldugunda sifirdan devam ederek tek gecis ile cozer.
// Zaman Karmasikligi: O(n) - dizi bir kez taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public int MaxSubArray(int[] dizi)
    {
        int mevcutToplam = dizi[0];
        int enBuyukToplam = dizi[0];

        for (int indeks = 1; indeks < dizi.Length; indeks++)
        {
            int sayi = dizi[indeks];
            mevcutToplam = Math.Max(sayi, mevcutToplam + sayi);
            enBuyukToplam = Math.Max(enBuyukToplam, mevcutToplam);
        }

        return enBuyukToplam;
    }
}
