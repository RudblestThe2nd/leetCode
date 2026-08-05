// 2 - Add Two Numbers - Medium
// Task: Add two non-empty linked lists whose digits are stored in reverse order and return the sum as a linked list.
// Official link: https://leetcode.com/problems/add-two-numbers/
// Difficulty: Medium
// Question number: 2
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Recursive (Ozyinelemeli) Cozum
// Zaman Karmasikligi: O(max(m, n))  -> her dugum icin bir kez recursive cagri yapiliyor
// Alan Karmasikligi: O(max(m, n))   -> call stack derinligi liste uzunlugu ile orantili

using System;

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return TopluHesapla(l1, l2, 0);
    }

    private ListNode TopluHesapla(ListNode l1, ListNode l2, int elden)
    {
        if (l1 == null && l2 == null && elden == 0)
        {
            return null;
        }

        int birinciDeger = (l1 != null) ? l1.deger : 0;
        int ikinciDeger = (l2 != null) ? l2.deger : 0;

        int toplam = birinciDeger + ikinciDeger + elden;

        ListNode dugum = new ListNode(toplam % 10);

        dugum.sonraki = TopluHesapla(
            l1?.sonraki,
            l2?.sonraki,
            toplam / 10
        );

        return dugum;
    }
}
