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

// Yaklasim: Ozyinelemeli (recursive) cozum, sarkan ucu (successor) tasiyarak
// Zaman Karmasikligi: O(n) - her dugum icin bir ozyinelemeli cagri
// Alan Karmasikligi: O(n) - cagri yiginindan dolayi
// Aciklama: Once sol pozisyona kadar ozyinelemeli olarak ilerliyoruz. sol
// pozisyona gelindiginde klasik "reverse first n nodes" mantigini
// uygulayip, cevrilen blogun hemen sonrasindaki dugumu bir alan
// degiskeninde saklayarak sonda dogru sekilde baglantiyi kuruyoruz.
public class Solution
{
    private ListNode sarkanDugum;

    public ListNode ReverseBetween(ListNode bas, int sol, int sag)
    {
        if (sol == 1)
        {
            return IlkNKadarTersCevir(bas, sag);
        }

        bas.sonraki = ReverseBetween(bas.sonraki, sol - 1, sag - 1);
        return bas;
    }

    private ListNode IlkNKadarTersCevir(ListNode bas, int n)
    {
        if (n == 1)
        {
            sarkanDugum = bas.sonraki;
            return bas;
        }

        var yeniBas = IlkNKadarTersCevir(bas.sonraki, n - 1);
        bas.sonraki.sonraki = bas;
        bas.sonraki = sarkanDugum;

        return yeniBas;
    }
}
