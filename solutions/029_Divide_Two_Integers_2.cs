// 29 - Divide Two Integers - Medium
// Task: Divide two integers without using multiplication, division, or modulo operators.
// Official link: https://leetcode.com/problems/divide-two-integers/
// Difficulty: Medium
// Question number: 29
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bolum Uzerinde Ikili Arama (Binary Search)
// Zaman Karmasikligi: O(log(n) * log(n)) - ikili arama adim sayisi ve her adimda toplama kontrolu
// Alan Karmasikligi: O(1) - sadece sabit sayida yardimci degisken kullanilir
// Turkce aciklama: Olasi bolum degerleri 0 ile bolunenin mutlak degeri arasinda ikili
// arama ile taranir. Her adayin bolenle carpimi (toplama yoluyla) bolunenden kucuk veya
// esitse aday buyutulur, degilse aday kucultulur. Tasma durumlari long ile onlenir.

using System;

public class Solution
{
    public int Divide(int bolunen, int bolen)
    {
        if (bolunen == int.MinValue && bolen == -1)
        {
            return int.MaxValue;
        }

        bool sonucNegatifMi = (bolunen < 0) != (bolen < 0);

        long bolunenMutlak = Math.Abs((long)bolunen);
        long bolenMutlak = Math.Abs((long)bolen);

        long sol = 0;
        long sag = bolunenMutlak;
        long enIyiSonuc = 0;

        while (sol <= sag)
        {
            long orta = sol + (sag - sol) / 2;

            if (CarpimKontrolEt(orta, bolenMutlak, bolunenMutlak))
            {
                enIyiSonuc = orta;
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return sonucNegatifMi ? (int)-enIyiSonuc : (int)enIyiSonuc;
    }

    private bool CarpimKontrolEt(long aday, long bolenMutlak, long bolunenMutlak)
    {
        long toplam = 0;

        for (long i = 0; i < aday; i++)
        {
            toplam += bolenMutlak;

            if (toplam > bolunenMutlak)
            {
                return false;
            }
        }

        return toplam <= bolunenMutlak;
    }
}
