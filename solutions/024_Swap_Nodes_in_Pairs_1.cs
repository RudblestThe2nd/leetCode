// 24 - Swap Nodes in Pairs - Medium
// Task: Swap every two adjacent nodes in a linked list without changing node values.
// Official link: https://leetcode.com/problems/swap-nodes-in-pairs/
// Difficulty: Medium
// Question number: 24
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (Dongu Tabanli)
// Zaman Karmasikligi: O(n) - her dugum bir defa gezilir
// Alan Karmasikligi: O(1) - sadece sabit sayida yardimci degisken kullanilir
// Turkce aciklama: Sahte bir bas dugum olusturulur, sonra ikili gruplar halinde
// dugumlerin baglantilari (isaretciler) dongu icinde yeniden duzenlenerek yer degistirilir.

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
        var sahteBas = new ListNode(0, bas);
        var onceki = sahteBas;

        while (onceki.sonraki != null && onceki.sonraki.sonraki != null)
        {
            var birinciDugum = onceki.sonraki;
            var ikinciDugum = onceki.sonraki.sonraki;

            birinciDugum.sonraki = ikinciDugum.sonraki;
            ikinciDugum.sonraki = birinciDugum;
            onceki.sonraki = ikinciDugum;

            onceki = birinciDugum;
        }

        return sahteBas.sonraki;
    }
}
