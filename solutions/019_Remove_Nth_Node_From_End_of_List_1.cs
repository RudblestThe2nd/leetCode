// 19 - Remove Nth Node From End of List - Medium
// Task: Remove the nth node from the end of a singly linked list and return the updated head.
// Official link: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// Difficulty: Medium
// Question number: 19
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki gecisli (Two-Pass) - once dugum sayisini say, sonra
// silinecek dugumden onceki dugume kadar ilerleyip baglantiyi guncelle.
// Zaman Karmasikligi: O(n) - listeyi iki kez tarar.
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
        int uzunluk = 0;
        DugumListe gecici = bas;

        while (gecici != null)
        {
            uzunluk += 1;
            gecici = gecici.sonraki;
        }

        var sahteBas = new DugumListe(0, bas);
        DugumListe onceki = sahteBas;

        int adimSayisi = uzunluk - n;

        for (int sayac = 0; sayac < adimSayisi; sayac++)
        {
            onceki = onceki.sonraki;
        }

        onceki.sonraki = onceki.sonraki.sonraki;

        return sahteBas.sonraki;
    }
}
