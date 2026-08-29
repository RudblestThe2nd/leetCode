// 25 - Reverse Nodes in k-Group - Hard
// Task: Reverse nodes of a linked list in groups of k, leaving any final short group unchanged.
// Official link: https://leetcode.com/problems/reverse-nodes-in-k-group/
// Difficulty: Hard
// Question number: 25
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (Dongu Tabanli)
// Zaman Karmasikligi: O(n) - her dugum bir defa ziyaret edilir
// Alan Karmasikligi: O(1) - sadece sabit sayida yardimci isaretci kullanilir
// Turkce aciklama: Once ilgili grupta k adet dugum olup olmadigi kontrol edilir.
// Yeterliyse grup icindeki baglantilar dongu ile ters cevrilir, sonra siradaki gruba gecilir.

public class ListNode
{
    public int deger;
    public ListNode sonraki;

    public ListNode(int deger = 0, ListNode sonraki = null)
    {
        this.deger = deger;
        this.sonraki = sonraki;
    }
}

public class Solution
{
    public ListNode ReverseKGroup(ListNode bas, int k)
    {
        var sahteBas = new ListNode(0, bas);
        var grupOncesi = sahteBas;

        while (true)
        {
            var kontrolDugumu = grupOncesi;

            for (int i = 0; i < k; i++)
            {
                kontrolDugumu = kontrolDugumu.sonraki;

                if (kontrolDugumu == null)
                {
                    return sahteBas.sonraki;
                }
            }

            var oncekiDugum = kontrolDugumu.sonraki;
            var suankiDugum = grupOncesi.sonraki;

            for (int i = 0; i < k; i++)
            {
                var sonrakiDugum = suankiDugum.sonraki;
                suankiDugum.sonraki = oncekiDugum;
                oncekiDugum = suankiDugum;
                suankiDugum = sonrakiDugum;
            }

            var eskiGrupBasi = grupOncesi.sonraki;
            grupOncesi.sonraki = oncekiDugum;
            grupOncesi = eskiGrupBasi;
        }
    }
}
