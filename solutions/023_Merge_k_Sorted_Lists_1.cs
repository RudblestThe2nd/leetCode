// 23 - Merge k Sorted Lists - Hard
// Task: Merge k sorted linked lists into one sorted linked list.
// Official link: https://leetcode.com/problems/merge-k-sorted-lists/
// Difficulty: Hard
// Question number: 23
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Min-Heap (Oncelik Kuyrugu)
// Zaman Karmasikligi: O(N log k) - N toplam dugum sayisi, k liste sayisi
// Alan Karmasikligi: O(k) - yigin (heap) icinde en fazla k eleman tutulur
// Turkce aciklama: Her listenin bas dugumu bir min-heap'e eklenir. Heap'ten en kucuk
// deger cikarilir, sonuc listesine eklenir ve o dugumun sonraki elemani heap'e konur.
// Bu islem heap bosalana kadar tekrarlanir.

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
    public ListNode MergeKLists(ListNode[] listeler)
    {
        var oncelikKuyrugu = new PriorityQueue<ListNode, int>();

        foreach (var liste in listeler)
        {
            if (liste != null)
            {
                oncelikKuyrugu.Enqueue(liste, liste.deger);
            }
        }

        var sahteBas = new ListNode(0);
        var suankiDugum = sahteBas;

        while (oncelikKuyrugu.Count > 0)
        {
            var enKucukDugum = oncelikKuyrugu.Dequeue();

            suankiDugum.sonraki = enKucukDugum;
            suankiDugum = suankiDugum.sonraki;

            if (enKucukDugum.sonraki != null)
            {
                oncelikKuyrugu.Enqueue(enKucukDugum.sonraki, enKucukDugum.sonraki.deger);
            }
        }

        return sahteBas.sonraki;
    }
}
