// 52 - N-Queens II - Hard
// Task: Return the number of valid n-queens board arrangements.
// Official link: https://leetcode.com/problems/n-queens-ii/
// Difficulty: Hard
// Question number: 52
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Backtracking + Kullanilan Sutun/Capraz Kumeleri (HashSet)
// N-Queens sorusuyla ayni mantik, ancak tahtayi olusturmak yerine
// sadece gecerli yerlesim sayisini sayariz. Her satirda musait bir
// sutun bulup derinlesir, tum satirlari doldurdugumuzda sayaci artiririz.
// Zaman Karmasikligi: O(n!) (en kotu durum, budama ile pratikte daha az)
// Alan Karmasikligi: O(n)

using System.Collections.Generic;

public class Solution
{
    public int TotalNQueens(int n)
    {
        HashSet<int> kullanilanSutunlar = new HashSet<int>();
        HashSet<int> kullanilanCaprazToplam = new HashSet<int>();
        HashSet<int> kullanilanCaprazFark = new HashSet<int>();

        return GeriDon(n, 0, kullanilanSutunlar, kullanilanCaprazToplam, kullanilanCaprazFark);
    }

    private int GeriDon(
        int n,
        int satir,
        HashSet<int> kullanilanSutunlar,
        HashSet<int> kullanilanCaprazToplam,
        HashSet<int> kullanilanCaprazFark)
    {
        if (satir == n)
        {
            return 1;
        }

        int gecerliSayim = 0;

        for (int sutun = 0; sutun < n; sutun++)
        {
            int caprazToplam = satir + sutun;
            int caprazFark = satir - sutun;

            bool cakisiyor =
                kullanilanSutunlar.Contains(sutun) ||
                kullanilanCaprazToplam.Contains(caprazToplam) ||
                kullanilanCaprazFark.Contains(caprazFark);

            if (cakisiyor)
            {
                continue;
            }

            kullanilanSutunlar.Add(sutun);
            kullanilanCaprazToplam.Add(caprazToplam);
            kullanilanCaprazFark.Add(caprazFark);

            gecerliSayim += GeriDon(n, satir + 1, kullanilanSutunlar, kullanilanCaprazToplam, kullanilanCaprazFark);

            kullanilanSutunlar.Remove(sutun);
            kullanilanCaprazToplam.Remove(caprazToplam);
            kullanilanCaprazFark.Remove(caprazFark);
        }

        return gecerliSayim;
    }
}
