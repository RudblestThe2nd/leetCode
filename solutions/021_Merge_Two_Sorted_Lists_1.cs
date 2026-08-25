// 21 - Merge Two Sorted Lists - Easy
// Task: Merge two sorted linked lists into one sorted linked list.
// Official link: https://leetcode.com/problems/merge-two-sorted-lists/
// Difficulty: Easy
// Question number: 21
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) birlestirme - sahte bas dugum kullanarak
// iki listeyi karsilastira karsilastira tek bir listeye baglar.
// Zaman Karmasikligi: O(n + m) - n ve m iki listenin uzunluklari.
// Alan Karmasikligi: O(1) - yeni dugum olusturulmaz, mevcut dugumler baglanir.

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
        var sahteBas = new DugumListe(0);
        DugumListe suanki = sahteBas;

        while (birinciListe != null && ikinciListe != null)
        {
            if (birinciListe.deger <= ikinciListe.deger)
            {
                suanki.sonraki = birinciListe;
                birinciListe = birinciListe.sonraki;
            }
            else
            {
                suanki.sonraki = ikinciListe;
                ikinciListe = ikinciListe.sonraki;
            }

            suanki = suanki.sonraki;
        }

        if (birinciListe != null)
        {
            suanki.sonraki = birinciListe;
        }
        else
        {
            suanki.sonraki = ikinciListe;
        }

        return sahteBas.sonraki;
    }
}
