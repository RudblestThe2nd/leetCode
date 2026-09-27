// 51 - N-Queens - Hard
// Task: Return all valid ways to place n queens on an n by n chessboard so none attack each other.
// Official link: https://leetcode.com/problems/n-queens/
// Difficulty: Hard
// Question number: 51
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Bit Manipulasyonu ile Backtracking (Bitmask Based)
// Kullanilan sutunlari ve iki capraz yonu, HashSet yerine tamsayi
// bitmaskeleri olarak tutariz. Her satirda, "musait" konumlari
// (kullanilmayan bitler) bitwise islemlerle hesaplariz. Bu, kume
// islemlerinden daha az bellek kullanir ve daha hizli calisir.
// Zaman Karmasikligi: O(n!) (en kotu durum, budama ile pratikte daha az)
// Alan Karmasikligi: O(n^2) (sonuc listesi icin), yardimci degiskenler O(n)

using System.Collections.Generic;
using System.Text;

public class Solution
{
    private int boyut;

    public IList<IList<string>> SolveNQueens(int n)
    {
        boyut = n;

        IList<IList<string>> sonuclar = new List<IList<string>>();

        int[] vezirSutunlari = new int[n];

        GeriDon(0, 0, 0, 0, vezirSutunlari, sonuclar);

        return sonuclar;
    }

    private void GeriDon(
        int satir,
        int kullanilanSutunMaskesi,
        int kullanilanSolCaprazMaskesi,
        int kullanilanSagCaprazMaskesi,
        int[] vezirSutunlari,
        IList<IList<string>> sonuclar)
    {
        if (satir == boyut)
        {
            sonuclar.Add(TahtaOlustur(vezirSutunlari));
            return;
        }

        int tamDolu = (1 << boyut) - 1;

        int dolMaske = kullanilanSutunMaskesi | kullanilanSolCaprazMaskesi | kullanilanSagCaprazMaskesi;

        int musaitKonumlar = tamDolu & ~dolMaske;

        while (musaitKonumlar != 0)
        {
            int secilenBit = musaitKonumlar & (-musaitKonumlar);

            musaitKonumlar -= secilenBit;

            int sutun = SayiKadarSifirSay(secilenBit);

            vezirSutunlari[satir] = sutun;

            GeriDon(
                satir + 1,
                kullanilanSutunMaskesi | secilenBit,
                (kullanilanSolCaprazMaskesi | secilenBit) << 1,
                (kullanilanSagCaprazMaskesi | secilenBit) >> 1,
                vezirSutunlari,
                sonuclar);
        }
    }

    private int SayiKadarSifirSay(int bit)
    {
        int sayac = 0;

        while ((bit & 1) == 0)
        {
            bit >>= 1;
            sayac++;
        }

        return sayac;
    }

    private List<string> TahtaOlustur(int[] vezirSutunlari)
    {
        List<string> tahta = new List<string>();

        for (int satir = 0; satir < boyut; satir++)
        {
            StringBuilder satirOlusturucu = new StringBuilder();

            for (int sutun = 0; sutun < boyut; sutun++)
            {
                satirOlusturucu.Append(sutun == vezirSutunlari[satir] ? 'Q' : '.');
            }

            tahta.Add(satirOlusturucu.ToString());
        }

        return tahta;
    }
}
