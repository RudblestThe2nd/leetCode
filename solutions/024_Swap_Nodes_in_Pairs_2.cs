// 24 - Swap Nodes in Pairs - Medium
// Task: Swap every two adjacent nodes in a linked list without changing node values.
// Official link: https://leetcode.com/problems/swap-nodes-in-pairs/
// Difficulty: Medium
// Question number: 24
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ozyinelemeli (Recursive)
// Zaman Karmasikligi: O(n) - her dugum bir defa islenir
// Alan Karmasikligi: O(n) - ozyineleme cagri yiginindan dolayi
// Turkce aciklama: Listenin ilk ikilisi degistirilip, kalan listenin ikili degisimi
// icin fonksiyon kendini cagirir. Sonuc olarak ikinci dugum yeni bas olur.

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
    public ListNode SwapPairs(ListNode bas)
    {
        if (bas == null || bas.sonraki == null)
        {
            return bas;
        }

        var birinciDugum = bas;
        var ikinciDugum = bas.sonraki;

        birinciDugum.sonraki = SwapPairs(ikinciDugum.sonraki);
        ikinciDugum.sonraki = birinciDugum;

        return ikinciDugum;
    }
}
