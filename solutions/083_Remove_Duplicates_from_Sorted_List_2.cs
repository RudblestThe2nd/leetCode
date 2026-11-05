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

// Yaklasim: Ozyinelemeli (Recursive) cozum
// Zaman Karmasikligi: O(n) - her dugum icin bir cagri yapilir
// Alan Karmasikligi: O(n) - cagri yiginindan dolayi
// Aciklama: Once listenin kalanini ozyinelemeli olarak temizliyoruz,
// sonra su anki dugum ile bir sonraki dugumun degeri esitse
// su anki dugumu atlayip temizlenmis kalani donduruyoruz.
public class Solution
{
    public ListNode DeleteDuplicates(ListNode bas)
    {
        if (bas == null || bas.sonraki == null)
        {
            return bas;
        }

        bas.sonraki = DeleteDuplicates(bas.sonraki);

        if (bas.deger == bas.sonraki.deger)
        {
            return bas.sonraki;
        }

        return bas;
    }
}
