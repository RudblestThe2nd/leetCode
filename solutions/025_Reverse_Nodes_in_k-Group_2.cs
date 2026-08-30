// 25 - Reverse Nodes in k-Group - Hard
// Task: Reverse nodes of a linked list in groups of k, leaving any final short group unchanged.
// Official link: https://leetcode.com/problems/reverse-nodes-in-k-group/
// Difficulty: Hard
// Question number: 25
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ozyinelemeli (Recursive)
// Zaman Karmasikligi: O(n) - her dugum bir defa islenir
// Alan Karmasikligi: O(n/k) - ozyineleme cagri yigininin derinligi icin
// Turkce aciklama: Once k dugumun var olup olmadigi kontrol edilir. Varsa grup ters
// cevrilir ve kalan liste icin fonksiyon kendini cagirir; sonuc grubun sonuna eklenir.

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
        var kontrolDugumu = bas;

        for (int i = 0; i < k; i++)
        {
            if (kontrolDugumu == null)
            {
                return bas;
            }

            kontrolDugumu = kontrolDugumu.sonraki;
        }

        var yeniBas = ReverseKGroup(kontrolDugumu, k);

        var suankiDugum = bas;
        var oncekiDugum = yeniBas;

        for (int i = 0; i < k; i++)
        {
            var sonrakiDugum = suankiDugum.sonraki;
            suankiDugum.sonraki = oncekiDugum;
            oncekiDugum = suankiDugum;
            suankiDugum = sonrakiDugum;
        }

        return oncekiDugum;
    }
}
