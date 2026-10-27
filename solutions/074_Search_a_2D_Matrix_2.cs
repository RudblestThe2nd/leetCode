// 74 - Search a 2D Matrix - Medium
// Task: Search for a target in a matrix whose rows are sorted and connected in sorted order.
// Official link: https://leetcode.com/problems/search-a-2d-matrix/
// Difficulty: Medium
// Question number: 74
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matrisi tek boyutlu siralanmis bir dizi gibi dusunup ikili arama (binary search)
// uyguluyoruz. Indeks donusumu ile (indeks / sutunSayisi, indeks % sutunSayisi) gercek
// satir ve sutuna erisiyoruz.
// Zaman Karmasikligi: O(log(satirSayisi * sutunSayisi))
// Alan Karmasikligi: O(1)

public class Solution
{
    public bool SearchMatrix(int[][] matris, int hedef)
    {
        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;

        int sol = 0;
        int sag = (satirSayisi * sutunSayisi) - 1;

        while (sol <= sag)
        {
            int orta = sol + (sag - sol) / 2;
            int satir = orta / sutunSayisi;
            int sutun = orta % sutunSayisi;
            int mevcutDeger = matris[satir][sutun];

            if (mevcutDeger == hedef)
            {
                return true;
            }
            else if (mevcutDeger < hedef)
            {
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return false;
    }
}
