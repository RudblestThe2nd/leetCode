// 21 - Merge Two Sorted Lists - Easy
// Task: Merge two sorted linked lists into one sorted linked list.
// Official link: https://leetcode.com/problems/merge-two-sorted-lists/
// Difficulty: Easy
// Question number: 21
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ozyinelemeli (Recursive) birlestirme - her adimda daha kucuk
// bastaki dugumu secip, kalan listelerin birlestirmesini ozyinelemeli cagirir.
// Zaman Karmasikligi: O(n + m) - n ve m iki listenin uzunluklari.
// Alan Karmasikligi: O(n + m) - ozyineleme cagri yigini icin.

using System;

public class DugumListe
{
    public int deger;
    public DugumListe sonraki;

    public DugumListe(int deger = 0, DugumListe sonraki = null)
    {
        this.deger = deger;
        this.sonraki = sonraki;
    }
}

public class Solution
{
    public DugumListe MergeTwoLists(DugumListe birinciListe, DugumListe ikinciListe)
    {
        if (birinciListe == null)
        {
            return ikinciListe;
        }

        if (ikinciListe == null)
        {
            return birinciListe;
        }

        if (birinciListe.deger <= ikinciListe.deger)
        {
            birinciListe.sonraki = MergeTwoLists(birinciListe.sonraki, ikinciListe);
            return birinciListe;
        }
        else
        {
            ikinciListe.sonraki = MergeTwoLists(birinciListe, ikinciListe.sonraki);
            return ikinciListe;
        }
    }
}
