// 82 - Remove Duplicates from Sorted List II - Medium
// Task: Remove all values that appear more than once from a sorted linked list.
// Official link: https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
// Difficulty: Medium
// Question number: 82
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Once her degerin listede kac kere gectigini bir haritada (dictionary) sayiyoruz,
// ardindan sadece bir kere gecen degerleri yeni bir baglantili listeye ekliyoruz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(uzunluk) (sayim haritasi ve yeni dugumler icin)

using System.Collections.Generic;

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
        Dictionary<int, int> degerSayimlari = new Dictionary<int, int>();
        ListNode gezici = bas;

        while (gezici != null)
        {
            if (!degerSayimlari.ContainsKey(gezici.deger))
            {
                degerSayimlari[gezici.deger] = 0;
            }

            degerSayimlari[gezici.deger]++;
            gezici = gezici.sonraki;
        }

        ListNode sahteBas = new ListNode(0);
        ListNode kuyrukDugum = sahteBas;
        gezici = bas;

        while (gezici != null)
        {
            if (degerSayimlari[gezici.deger] == 1)
            {
                kuyrukDugum.sonraki = new ListNode(gezici.deger);
                kuyrukDugum = kuyrukDugum.sonraki;
            }

            gezici = gezici.sonraki;
        }

        return sahteBas.sonraki;
    }
}
