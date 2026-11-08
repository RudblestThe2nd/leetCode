// 86 - Partition List - Medium
// Task: Partition a linked list so nodes less than x come before nodes greater than or equal to x, preserving relative order.
// Official link: https://leetcode.com/problems/partition-list/
// Difficulty: Medium
// Question number: 86
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

// Yaklasim: Degerleri diziye kopyalayip kararli (stable) sekilde ayirma,
// sonra yeni dugumlerden tek listeyi yeniden olusturma
// Zaman Karmasikligi: O(n) - listeyi okuma ve yeniden olusturma
// Alan Karmasikligi: O(n) - degerleri tutan yardimci diziler icin
// Aciklama: Once tum degerleri bir listeye topluyoruz, ardindan sinirdan
// kucuk olanlari ve buyuk/esit olanlari sirayla iki ayri listeye ayirip
// bunlari birlestirerek yepyeni dugumlerden olusan sonucu donduruyoruz.
public class Solution
{
    public ListNode Partition(ListNode bas, int sinir)
    {
        var tumDegerler = new System.Collections.Generic.List<int>();
        var gecici = bas;

        while (gecici != null)
        {
            tumDegerler.Add(gecici.deger);
            gecici = gecici.sonraki;
        }

        var kucukListe = new System.Collections.Generic.List<int>();
        var buyukListe = new System.Collections.Generic.List<int>();

        foreach (var deger in tumDegerler)
        {
            if (deger < sinir)
            {
                kucukListe.Add(deger);
            }
            else
            {
                buyukListe.Add(deger);
            }
        }

        var sahteBas = new ListNode(0);
        var kuyruk = sahteBas;

        foreach (var deger in kucukListe)
        {
            kuyruk.sonraki = new ListNode(deger);
            kuyruk = kuyruk.sonraki;
        }

        foreach (var deger in buyukListe)
        {
            kuyruk.sonraki = new ListNode(deger);
            kuyruk = kuyruk.sonraki;
        }

        return sahteBas.sonraki;
    }
}
