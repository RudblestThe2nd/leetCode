// 23 - Merge k Sorted Lists - Hard
// Task: Merge k sorted linked lists into one sorted linked list.
// Official link: https://leetcode.com/problems/merge-k-sorted-lists/
// Difficulty: Hard
// Question number: 23
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bol ve Fetih (Divide and Conquer) - Ikili Birlestirme
// Zaman Karmasikligi: O(N log k) - N toplam dugum sayisi, k liste sayisi
// Alan Karmasikligi: O(log k) - ozyineleme (recursion) yigin derinligi icin
// Turkce aciklama: Listeler ikiser ikiser gruplanir ve her grup kendi icinde
// birlestirilir. Bu islem, tek bir liste kalana kadar tekrarlanir (merge sort mantigi).

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
        if (listeler == null || listeler.Length == 0)
        {
            return null;
        }

        return BolVeBirlestir(listeler, 0, listeler.Length - 1);
    }

    private ListNode BolVeBirlestir(ListNode[] listeler, int sol, int sag)
    {
        if (sol == sag)
        {
            return listeler[sol];
        }

        if (sol > sag)
        {
            return null;
        }

        int orta = sol + (sag - sol) / 2;

        var solListe = BolVeBirlestir(listeler, sol, orta);
        var sagListe = BolVeBirlestir(listeler, orta + 1, sag);

        return IkiListeyiBirlestir(solListe, sagListe);
    }

    private ListNode IkiListeyiBirlestir(ListNode birinci, ListNode ikinci)
    {
        var sahteBas = new ListNode(0);
        var suankiDugum = sahteBas;

        while (birinci != null && ikinci != null)
        {
            if (birinci.deger <= ikinci.deger)
            {
                suankiDugum.sonraki = birinci;
                birinci = birinci.sonraki;
            }
            else
            {
                suankiDugum.sonraki = ikinci;
                ikinci = ikinci.sonraki;
            }

            suankiDugum = suankiDugum.sonraki;
        }

        suankiDugum.sonraki = (birinci != null) ? birinci : ikinci;

        return sahteBas.sonraki;
    }
}
