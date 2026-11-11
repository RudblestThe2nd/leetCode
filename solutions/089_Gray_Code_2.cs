// 89 - Gray Code - Medium
// Task: Generate a Gray code sequence of length 2 to the power n.
// Official link: https://leetcode.com/problems/gray-code/
// Difficulty: Medium
// Question number: 89
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Onceki adimin sonucunu yansitip (reflect) en yuksek bite 1 ekleme
// Zaman Karmasikligi: O(2^n) - her adimda liste iki katina cikar
// Alan Karmasikligi: O(2^n) - sonuc listesi icin
// Aciklama: Her adimda, o ana kadar olusturulmus listeyi tersten alip her
// elemana en yuksek bite karsilik gelen degeri ekleyerek listenin sonuna
// ekliyoruz. Bu, klasik "reflect and prefix" yontemidir.
public class Solution
{
    public System.Collections.Generic.IList<int> GrayCode(int n)
    {
        var sonuc = new System.Collections.Generic.List<int>();
        sonuc.Add(0);

        for (int bitIndeksi = 0; bitIndeksi < n; bitIndeksi++)
        {
            int eklenecekDeger = 1 << bitIndeksi;
            int mevcutUzunluk = sonuc.Count;

            for (int indeks = mevcutUzunluk - 1; indeks >= 0; indeks--)
            {
                sonuc.Add(sonuc[indeks] + eklenecekDeger);
            }
        }

        return sonuc;
    }
}
