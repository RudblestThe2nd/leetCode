// 51 - N-Queens - Hard
// Task: Return all valid ways to place n queens on an n by n chessboard so none attack each other.
// Official link: https://leetcode.com/problems/n-queens/
// Difficulty: Hard
// Question number: 51
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Backtracking + Kullanilan Sutun/Capraz Kumeleri (HashSet)
// Satir satir ilerleyip her satirda bir vezir yerlestiririz. Kullanilan
// sutunlari ve iki capraz yonu (satir-sutun, satir+sutun) kumelerde
// tutarak cakisma kontrolunu O(1)'e yakin yapariz.
// Zaman Karmasikligi: O(n!) (en kotu durum, budama ile pratikte daha az)
// Alan Karmasikligi: O(n^2) (tahta ve sonuc listesi icin)

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> sonuclar = new List<IList<string>>();

        int[] vezirSutunlari = new int[n];

        HashSet<int> kullanilanSutunlar = new HashSet<int>();
        HashSet<int> kullanilanCaprazToplam = new HashSet<int>();
        HashSet<int> kullanilanCaprazFark = new HashSet<int>();

        GeriDon(n, 0, vezirSutunlari, kullanilanSutunlar, kullanilanCaprazToplam, kullanilanCaprazFark, sonuclar);

        return sonuclar;
    }

    private void GeriDon(
        int n,
        int satir,
        int[] vezirSutunlari,
        HashSet<int> kullanilanSutunlar,
        HashSet<int> kullanilanCaprazToplam,
        HashSet<int> kullanilanCaprazFark,
        IList<IList<string>> sonuclar)
    {
        if (satir == n)
        {
            sonuclar.Add(TahtaOlustur(n, vezirSutunlari));
            return;
        }

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

            vezirSutunlari[satir] = sutun;
            kullanilanSutunlar.Add(sutun);
            kullanilanCaprazToplam.Add(caprazToplam);
            kullanilanCaprazFark.Add(caprazFark);

            GeriDon(n, satir + 1, vezirSutunlari, kullanilanSutunlar, kullanilanCaprazToplam, kullanilanCaprazFark, sonuclar);

            kullanilanSutunlar.Remove(sutun);
            kullanilanCaprazToplam.Remove(caprazToplam);
            kullanilanCaprazFark.Remove(caprazFark);
        }
    }

    private List<string> TahtaOlustur(int n, int[] vezirSutunlari)
    {
        List<string> tahta = new List<string>();

        for (int satir = 0; satir < n; satir++)
        {
            StringBuilder satirOlusturucu = new StringBuilder();

            for (int sutun = 0; sutun < n; sutun++)
            {
                satirOlusturucu.Append(sutun == vezirSutunlari[satir] ? 'Q' : '.');
            }

            tahta.Add(satirOlusturucu.ToString());
        }

        return tahta;
    }
}
