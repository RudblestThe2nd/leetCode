// 53 - Maximum Subarray - Medium
// Task: Find the contiguous subarray with the largest possible sum.
// Official link: https://leetcode.com/problems/maximum-subarray/
// Difficulty: Medium
// Question number: 53
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Brute Force - her olasi alt diziyi denetleyip toplamlarini hesaplama.
// Zaman Karmasikligi: O(n^2) - iki ic ice donguyle tum alt diziler taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public int MaxSubArray(int[] dizi)
    {
        int enBuyukToplam = dizi[0];

        for (int baslangic = 0; baslangic < dizi.Length; baslangic++)
        {
            int toplam = 0;

            for (int bitis = baslangic; bitis < dizi.Length; bitis++)
            {
                toplam += dizi[bitis];

                if (toplam > enBuyukToplam)
                {
                    enBuyukToplam = toplam;
                }
            }
        }

        return enBuyukToplam;
    }
}
