// 81 - Search in Rotated Sorted Array II - Medium
// Task: Search for a target in a rotated sorted array that may contain duplicates.
// Official link: https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
// Difficulty: Medium
// Question number: 81
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Degistirilmis ikili arama (binary search). Sol, orta ve sag
// degerlerini karsilastirarak hangi yarinin siralanmis oldugunu belirliyoruz.
// Sol ve sag degerler esit oldugunda (tekrar durumu) araligi bir adim daraltiyoruz.
// Zaman Karmasikligi: Ortalama O(log uzunluk), en kotu durumda O(uzunluk) (cok tekrarli veride)
// Alan Karmasikligi: O(1)

public class Solution
{
    public bool Search(int[] dizi, int hedef)
    {
        int sol = 0;
        int sag = dizi.Length - 1;

        while (sol <= sag)
        {
            int orta = sol + (sag - sol) / 2;

            if (dizi[orta] == hedef)
            {
                return true;
            }

            if (dizi[sol] == dizi[orta] && dizi[orta] == dizi[sag])
            {
                sol++;
                sag--;
            }
            else if (dizi[sol] <= dizi[orta])
            {
                if (dizi[sol] <= hedef && hedef < dizi[orta])
                {
                    sag = orta - 1;
                }
                else
                {
                    sol = orta + 1;
                }
            }
            else
            {
                if (dizi[orta] < hedef && hedef <= dizi[sag])
                {
                    sol = orta + 1;
                }
                else
                {
                    sag = orta - 1;
                }
            }
        }

        return false;
    }
}
