// 1 - Two Sum - Easy
// Task: Given an integer array and a target, return the indices of two numbers whose sum equals the target.
// Official link: https://leetcode.com/problems/two-sum/
// Difficulty: Easy
// Question number: 1
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Brute Force (Iki Ic Ice Dongu)
// Zaman Karmasikligi: O(n^2)  -> her eleman icin diger tum elemanlarla karsilastirma yapiliyor
// Alan Karmasikligi: O(1)     -> ekstra bir veri yapisi kullanilmiyor

using System;

class Program
{
    static void Main()
    {
        int[] dizi = { 2, 1, 5, 3 };
        int hedef = 4;

        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[i] + dizi[j] == hedef)
                {
                    Console.WriteLine(
                        $"Sayilar: {dizi[i]} ve {dizi[j]}"
                    );

                    Console.WriteLine(
                        $"Indeksler: {i} ve {j}"
                    );
                }
            }
        }
    }
}
