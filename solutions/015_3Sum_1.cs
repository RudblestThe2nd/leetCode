// 15 - 3Sum - Medium
// Task: Find all unique triplets in an array whose values sum to zero.
// Official link: https://leetcode.com/problems/3sum/
// Difficulty: Medium
// Question number: 15
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Once diziyi sirala, sonra her eleman icin iki isaretci (two-pointer)
// yontemiyle kalan iki sayiyi ara.
// Zaman Karmasikligi: O(n^2) - siralama O(n log n), ic dongu O(n^2).
// Alan Karmasikligi: O(n) - sonuc listesi ve siralama icin kullanilan alan.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] sayilar)
    {
        var sonuc = new List<IList<int>>();

        Array.Sort(sayilar);

        int uzunluk = sayilar.Length;

        for (int ilkIndeks = 0; ilkIndeks < uzunluk - 2; ilkIndeks++)
        {
            if (ilkIndeks > 0 && sayilar[ilkIndeks] == sayilar[ilkIndeks - 1])
            {
                continue;
            }

            int sol = ilkIndeks + 1;
            int sag = uzunluk - 1;

            while (sol < sag)
            {
                int toplam = sayilar[ilkIndeks] + sayilar[sol] + sayilar[sag];

                if (toplam == 0)
                {
                    sonuc.Add(new List<int> { sayilar[ilkIndeks], sayilar[sol], sayilar[sag] });

                    while (sol < sag && sayilar[sol] == sayilar[sol + 1])
                    {
                        sol += 1;
                    }

                    while (sol < sag && sayilar[sag] == sayilar[sag - 1])
                    {
                        sag -= 1;
                    }

                    sol += 1;
                    sag -= 1;
                }
                else if (toplam < 0)
                {
                    sol += 1;
                }
                else
                {
                    sag -= 1;
                }
            }
        }

        return sonuc;
    }
}
