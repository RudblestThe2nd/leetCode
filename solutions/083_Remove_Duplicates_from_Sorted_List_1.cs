// 83 - Remove Duplicates from Sorted List - Easy
// Task: Remove duplicate nodes from a sorted linked list, keeping one copy of each value.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
// Difficulty: Easy
// Question number: 83
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

// Yaklasim: Iteratif tek gecis
// Zaman Karmasikligi: O(n) - liste bir kez taranir
// Alan Karmasikligi: O(1) - ek veri yapisi kullanilmiyor
// Aciklama: Su anki dugumden baslayarak, kendisiyle ayni degere sahip
// sonraki dugumleri atlayarak baglantiyi kopruluyoruz.
public class Solution
{
    public ListNode DeleteDuplicates(ListNode bas)
    {
        ListNode simdiki = bas;

        while (simdiki != null && simdiki.sonraki != null)
        {
            if (simdiki.deger == simdiki.sonraki.deger)
            {
                simdiki.sonraki = simdiki.sonraki.sonraki;
            }
            else
            {
                simdiki = simdiki.sonraki;
            }
        }

        return bas;
    }
}
