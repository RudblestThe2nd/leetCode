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

// Yaklasim: Iki pointer (fast/slow) ile k adim ileri kaydirma - hizli isaretci
// once k adim ilerletilir, sonra ikisi birlikte listenin sonuna kadar hareket ettirilir.
// Zaman Karmasikligi: O(n) - liste bir kez uzunlugu bulmak icin, bir kez de kaydirma icin taranir.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    public DugumListe RotateRight(DugumListe bas, int k)
    {
        if (bas == null || bas.sonraki == null || k == 0)
        {
            return bas;
        }

        int uzunluk = 0;
        DugumListe sayac = bas;

        while (sayac != null)
        {
            uzunluk++;
            sayac = sayac.sonraki;
        }

        int kaydirma = k % uzunluk;

        if (kaydirma == 0)
        {
            return bas;
        }

        DugumListe hizli = bas;

        for (int adim = 0; adim < kaydirma; adim++)
        {
            hizli = hizli.sonraki;
        }

        DugumListe yavas = bas;

        while (hizli.sonraki != null)
        {
            hizli = hizli.sonraki;
            yavas = yavas.sonraki;
        }

        DugumListe yeniBas = yavas.sonraki;
        yavas.sonraki = null;
        hizli.sonraki = bas;

        return yeniBas;
    }
}
