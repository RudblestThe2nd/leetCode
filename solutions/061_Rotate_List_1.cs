// 61 - Rotate List - Medium
// Task: Rotate a linked list to the right by k positions.
// Official link: https://leetcode.com/problems/rotate-list/
// Difficulty: Medium
// Question number: 61
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

public class DugumListe
{
    public int deger;
    public DugumListe sonraki;
    public DugumListe(int deger = 0, DugumListe sonraki = null)
    {
        this.deger = deger;
        this.sonraki = sonraki;
    }
}

// Yaklasim: Uzunlugu bul, listeyi halka (circular) haline getir, sonra
// dogru noktadan kesip yeni bas dugumu belirle.
// Zaman Karmasikligi: O(n) - liste en fazla iki kez bastan sona taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public DugumListe RotateRight(DugumListe bas, int k)
    {
        if (bas == null || bas.sonraki == null || k == 0)
        {
            return bas;
        }

        int uzunluk = 1;
        DugumListe mevcut = bas;

        while (mevcut.sonraki != null)
        {
            mevcut = mevcut.sonraki;
            uzunluk++;
        }

        mevcut.sonraki = bas;

        int kaydirma = k % uzunluk;
        int adimSayisi = uzunluk - kaydirma;

        DugumListe yeniKuyruk = bas;

        for (int adim = 1; adim < adimSayisi; adim++)
        {
            yeniKuyruk = yeniKuyruk.sonraki;
        }

        DugumListe yeniBas = yeniKuyruk.sonraki;
        yeniKuyruk.sonraki = null;

        return yeniBas;
    }
}
