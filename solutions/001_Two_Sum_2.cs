// 1 - Two Sum - Easy
// Task: Given an integer array and a target, return the indices of two numbers whose sum equals the target.
// Official link: https://leetcode.com/problems/two-sum/
// Difficulty: Easy
// Question number: 1
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Hash Map (Dictionary) ile Tek Gecis
// Zaman Karmasikligi: O(n)  -> dizi bir kere bastan sona geziliyor, dictionary aramasi O(1)
// Alan Karmasikligi: O(n)   -> en fazla n eleman dictionary'ye eklenebilir

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] dizi = { 2, 1, 5, 3 };
        int hedef = 4;

        Dictionary<int, int> gorulenler = new Dictionary<int, int>();

        for (int i = 0; i < dizi.Length; i++)
        {
            int tamamlayici = hedef - dizi[i];

            if (gorulenler.ContainsKey(tamamlayici))
            {
                Console.WriteLine(
                    $"Sayilar: {tamamlayici} ve {dizi[i]}"
                );

                Console.WriteLine(
                    $"Indeksler: {gorulenler[tamamlayici]} ve {i}"
                );

                return;
            }

            gorulenler[dizi[i]] = i;
        }

        Console.WriteLine("Uygun ikili bulunamadi.");
    }
}
