// 33 - Search in Rotated Sorted Array - Medium
// Task: Search for a target in a rotated sorted array and return its index or -1.
// Official link: https://leetcode.com/problems/search-in-rotated-sorted-array/
// Difficulty: Medium
// Question number: 33
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Iki asamali - once donme noktasini (pivot) bul, sonra o parcada normal binary search yap
// Once dizinin en kucuk elemaninin indeksini binary search ile buluyoruz.
// Bu indeks bize hangi yarim dizide arama yapmamiz gerektigini gosteriyor,
// ardindan o yarimda klasik binary search calistiriyoruz.
// Zaman Karmasikligi: O(log n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int uzunluk = nums.Length;
        if (uzunluk == 0)
        {
            return -1;
        }

        int donmeNoktasi = DonmeNoktasiniBul(nums);

        int gercekSol = 0;
        int gercekSag = uzunluk - 1;

        // Hedefin hangi yarimda oldugunu belirle
        if (target >= nums[donmeNoktasi] && target <= nums[gercekSag])
        {
            gercekSol = donmeNoktasi;
        }
        else
        {
            gercekSag = donmeNoktasi - 1;
        }

        return KlasikBinarySearch(nums, target, gercekSol, gercekSag);
    }

    private int DonmeNoktasiniBul(int[] dizi)
    {
        int sol = 0;
        int sag = dizi.Length - 1;

        while (sol < sag)
        {
            int orta = sol + (sag - sol) / 2;

            if (dizi[orta] > dizi[sag])
            {
                sol = orta + 1;
            }
            else
            {
                sag = orta;
            }
        }

        return sol;
    }

    private int KlasikBinarySearch(int[] dizi, int hedef, int sol, int sag)
    {
        while (sol <= sag)
        {
            int orta = sol + (sag - sol) / 2;

            if (dizi[orta] == hedef)
            {
                return orta;
            }
            else if (dizi[orta] < hedef)
            {
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return -1;
    }
}
