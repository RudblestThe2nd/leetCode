// 29 - Divide Two Integers - Medium
// Task: Divide two integers without using multiplication, division, or modulo operators.
// Official link: https://leetcode.com/problems/divide-two-integers/
// Difficulty: Medium
// Question number: 29
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bit Kaydirma ile Ikiye Katlayarak Cikarma (Exponential Subtraction)
// Zaman Karmasikligi: O(log^2(n)) - her adimda bolen ikiye katlanir, dis dongu de logaritmiktir
// Alan Karmasikligi: O(1) - sadece sabit sayida yardimci degisken kullanilir
// Turkce aciklama: Bolunenden, bolenin art art ikiye katlanmis hali cikarilarak bolum
// bulunur. Tasma (overflow) durumlarini (ornegin INT_MIN / -1) ele almak icin islemler
// long tipiyle yapilir.

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

        long sonuc = 0;

        while (bolunenMutlak >= bolenMutlak)
        {
            long gecici = bolenMutlak;
            long katSayi = 1;

            while (bolunenMutlak >= (gecici << 1))
            {
                gecici <<= 1;
                katSayi <<= 1;
            }

            bolunenMutlak -= gecici;
            sonuc += katSayi;
        }

        return sonucNegatifMi ? (int)-sonuc : (int)sonuc;
    }
}
