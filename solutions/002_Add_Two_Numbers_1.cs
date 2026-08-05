// 2 - Add Two Numbers - Medium
// Task: Add two non-empty linked lists whose digits are stored in reverse order and return the sum as a linked list.
// Official link: https://leetcode.com/problems/add-two-numbers/
// Difficulty: Medium
// Question number: 2
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Iteratif - Dummy Head Node ile Tek Gecis
// Zaman Karmasikligi: O(max(m, n))  -> m ve n, iki listenin uzunluklari; daha uzun liste kadar donuluyor
// Alan Karmasikligi: O(max(m, n))   -> sonuc listesi en fazla bir hane daha uzun olabilir

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
        ListNode sahteBaslangic = new ListNode(0);
        ListNode mevcut = sahteBaslangic;

        int elden = 0;

        while (l1 != null || l2 != null || elden != 0)
        {
            int birinciDeger = (l1 != null) ? l1.deger : 0;
            int ikinciDeger = (l2 != null) ? l2.deger : 0;

            int toplam = birinciDeger + ikinciDeger + elden;

            elden = toplam / 10;

            mevcut.sonraki = new ListNode(toplam % 10);
            mevcut = mevcut.sonraki;

            if (l1 != null)
            {
                l1 = l1.sonraki;
            }

            if (l2 != null)
            {
                l2 = l2.sonraki;
            }
        }

        return sahteBaslangic.sonraki;
    }
}
