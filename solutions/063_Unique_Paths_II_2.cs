// 63 - Unique Paths II - Medium
// Task: Count unique grid paths when some cells are blocked by obstacles.
// Official link: https://leetcode.com/problems/unique-paths-ii/
// Difficulty: Medium
// Question number: 63
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 1D DP (yer tasarrufu optimize edilmis, tek satirlik dizi ile)
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi)
// Alan Karmasikligi: O(sutunSayisi)
// Aciklama: Tek boyutlu bir dizi tutulur, bu dizi o ana kadar islenen satirin
// sonuclarini temsil eder. Her yeni satir icin dizi guncellenerek 2D dp
// dizisine olan ihtiyac ortadan kaldirilir.

public class Solution
{
    public int UniquePathsWithObstacles(int[][] engelIzgarasi)
    {
        int satirSayisi = engelIzgarasi.Length;
        int sutunSayisi = engelIzgarasi[0].Length;

        int[] dizi = new int[sutunSayisi];
        dizi[0] = 1;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (engelIzgarasi[satir][sutun] == 1)
                {
                    dizi[sutun] = 0;
                }
                else if (sutun > 0)
                {
                    dizi[sutun] += dizi[sutun - 1];
                }
            }
        }

        return dizi[sutunSayisi - 1];
    }
}
