// 92 - Reverse Linked List II - Medium
// Task: Reverse the nodes of a linked list from position left to position right.
// Official link: https://leetcode.com/problems/reverse-linked-list-ii/
// Difficulty: Medium
// Question number: 92
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

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

// Yaklasim: Iteratif tek gecis, baglanti cevirme (pointer reversal)
// Zaman Karmasikligi: O(n) - liste bir kez taranir
// Alan Karmasikligi: O(1) - sadece sabit sayida isaretci kullanilir
// Aciklama: Sahte bir bas dugum ile sol pozisyondan bir onceki dugume
// ulasiyoruz. Ardindan sol ile sag arasindaki dugumleri klasik baglanti
// cevirme yontemiyle tek tek onune ekleyerek ters cevirip, sonunda
// cevrilen blogu listenin kalanina yeniden bagliyoruz.
public class Solution
{
    public ListNode ReverseBetween(ListNode bas, int sol, int sag)
    {
        var sahteBas = new ListNode(0);
        sahteBas.sonraki = bas;

        var oncekiDugum = sahteBas;
        for (int sayac = 0; sayac < sol - 1; sayac++)
        {
            oncekiDugum = oncekiDugum.sonraki;
        }

        var guncelDugum = oncekiDugum.sonraki;

        for (int sayac = 0; sayac < sag - sol; sayac++)
        {
            var sonrakiDugum = guncelDugum.sonraki;
            guncelDugum.sonraki = sonrakiDugum.sonraki;
            sonrakiDugum.sonraki = oncekiDugum.sonraki;
            oncekiDugum.sonraki = sonrakiDugum;
        }

        return sahteBas.sonraki;
    }
}
