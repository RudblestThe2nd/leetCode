// 15 - 3Sum - Medium
// Task: Find all unique triplets in an array whose values sum to zero.
// Official link: https://leetcode.com/problems/3sum/
// Difficulty: Medium
// Question number: 15
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: HashSet tabanli - ilk iki sayiyi sabitleyip, ucuncu sayinin
// (toplam icin gereken deger) daha once gorulup gorulmedigini bir kumede arar.
// Tekrarlari engellemek icin sonuc kumesi string anahtarlarla saklanir.
// Zaman Karmasikligi: O(n^2) - iki ic ice dongu.
// Alan Karmasikligi: O(n) - her satirda kullanilan hashset ve sonuc kumesi icin.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] sayilar)
    {
        Array.Sort(sayilar);

        var benzersizSonuclar = new HashSet<string>();
        var sonuc = new List<IList<int>>();

        int uzunluk = sayilar.Length;

        for (int ilkIndeks = 0; ilkIndeks < uzunluk - 2; ilkIndeks++)
        {
            var gorulenler = new HashSet<int>();

            for (int ikinciIndeks = ilkIndeks + 1; ikinciIndeks < uzunluk; ikinciIndeks++)
            {
                int gerekenDeger = -(sayilar[ilkIndeks] + sayilar[ikinciIndeks]);

                if (gorulenler.Contains(gerekenDeger))
                {
                    var uclu = new List<int> { sayilar[ilkIndeks], gerekenDeger, sayilar[ikinciIndeks] };
                    uclu.Sort();

                    string anahtar = uclu[0] + "_" + uclu[1] + "_" + uclu[2];

                    if (!benzersizSonuclar.Contains(anahtar))
                    {
                        benzersizSonuclar.Add(anahtar);
                        sonuc.Add(uclu);
                    }
                }

                gorulenler.Add(sayilar[ikinciIndeks]);
            }
        }

        return sonuc;
    }
}
