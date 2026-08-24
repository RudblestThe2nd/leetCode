// 19 - Remove Nth Node From End of List - Medium
// Task: Remove the nth node from the end of a singly linked list and return the updated head.
// Official link: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// Difficulty: Medium
// Question number: 19
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Tek gecisli (One-Pass), iki isaretci (fast-slow pointer) yontemi.
// Hizli isaretci once n adim ilerler, sonra ikisi birlikte hareket eder.
// Zaman Karmasikligi: O(n) - listeyi bir kez tarar.
// Alan Karmasikligi: O(1) - sabit ek alan.

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
    public DugumListe RemoveNthFromEnd(DugumListe bas, int n)
    {
        var sahteBas = new DugumListe(0, bas);
        DugumListe yavasIsaretci = sahteBas;
        DugumListe hizliIsaretci = sahteBas;

        for (int sayac = 0; sayac < n; sayac++)
        {
            hizliIsaretci = hizliIsaretci.sonraki;
        }

        while (hizliIsaretci.sonraki != null)
        {
            yavasIsaretci = yavasIsaretci.sonraki;
            hizliIsaretci = hizliIsaretci.sonraki;
        }

        yavasIsaretci.sonraki = yavasIsaretci.sonraki.sonraki;

        return sahteBas.sonraki;
    }
}
