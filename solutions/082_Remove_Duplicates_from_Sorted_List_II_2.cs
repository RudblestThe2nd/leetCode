// 82 - Remove Duplicates from Sorted List II - Medium
// Task: Remove all values that appear more than once from a sorted linked list.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
// Difficulty: Medium
// Question number: 82
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ekstra alan kullanmadan tek gecisli isaretci yontemi. Sahte bir bas
// dugum ile onceki dugumu takip ederiz; sirali liste oldugu icin ayni degere sahip
// tum dugumlari tek bir tarama sirasinda atlayip baglantiyi guncelleriz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1) (sadece sahte bas dugumu haric yeni dugum olusturulmaz)

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
    public ListNode DeleteDuplicates(ListNode bas)
    {
        ListNode sahteBas = new ListNode(0, bas);
        ListNode oncekiDugum = sahteBas;
        ListNode mevcutDugum = bas;

        while (mevcutDugum != null)
        {
            if (mevcutDugum.sonraki != null && mevcutDugum.deger == mevcutDugum.sonraki.deger)
            {
                int tekrarliDeger = mevcutDugum.deger;

                while (mevcutDugum != null && mevcutDugum.deger == tekrarliDeger)
                {
                    mevcutDugum = mevcutDugum.sonraki;
                }

                oncekiDugum.sonraki = mevcutDugum;
            }
            else
            {
                oncekiDugum = mevcutDugum;
                mevcutDugum = mevcutDugum.sonraki;
            }
        }

        return sahteBas.sonraki;
    }
}
