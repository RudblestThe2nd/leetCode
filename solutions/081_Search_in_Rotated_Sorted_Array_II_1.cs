// 81 - Search in Rotated Sorted Array II - Medium
// Task: Search for a target in a rotated sorted array that may contain duplicates.
// Official link: https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
// Difficulty: Medium
// Question number: 81
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba kuvvet (brute force) dogrusal arama. Dizinin donmus ve
// tekrarli olmasi onemli degildir; her elemani tek tek kontrol ediyoruz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1)

public class Solution
{
    public bool Search(int[] dizi, int hedef)
    {
        int uzunluk = dizi.Length;

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            if (dizi[indeks] == hedef)
            {
                return true;
            }
        }

        return false;
    }
}
