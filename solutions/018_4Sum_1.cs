// 18 - 4Sum - Medium
// Task: Find all unique quadruplets in an array whose values sum to a target.
// Official link: https://leetcode.com/problems/4sum/
// Difficulty: Medium
// Question number: 18
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Siralama + iki sabit dongu + iki isaretci (two-pointer).
// Diziyi sirala, ilk iki sayiyi sabitle, kalan iki sayiyi isaretcilerle bul.
// Zaman Karmasikligi: O(n^3) - iki ic ice dongu ve icteki two-pointer taramasi.
// Alan Karmasikligi: O(n) - sonuc listesi ve siralama icin kullanilan alan.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FourSum(int[] sayilar, int hedef)
    {
        var sonuc = new List<IList<int>>();

        Array.Sort(sayilar);

        int uzunluk = sayilar.Length;

        for (int birinciIndeks = 0; birinciIndeks < uzunluk - 3; birinciIndeks++)
        {
            if (birinciIndeks > 0 && sayilar[birinciIndeks] == sayilar[birinciIndeks - 1])
            {
                continue;
            }

            for (int ikinciIndeks = birinciIndeks + 1; ikinciIndeks < uzunluk - 2; ikinciIndeks++)
            {
                if (ikinciIndeks > birinciIndeks + 1 && sayilar[ikinciIndeks] == sayilar[ikinciIndeks - 1])
                {
                    continue;
                }

                int sol = ikinciIndeks + 1;
                int sag = uzunluk - 1;

                while (sol < sag)
                {
                    long toplam = (long)sayilar[birinciIndeks] + sayilar[ikinciIndeks] + sayilar[sol] + sayilar[sag];

                    if (toplam == hedef)
                    {
                        sonuc.Add(new List<int> { sayilar[birinciIndeks], sayilar[ikinciIndeks], sayilar[sol], sayilar[sag] });

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
                    else if (toplam < hedef)
                    {
                        sol += 1;
                    }
                    else
                    {
                        sag -= 1;
                    }
                }
            }
        }

        return sonuc;
    }
}
