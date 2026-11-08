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

// Yaklasim: Iki ayri sahte bas (dummy) dugum kullanarak listeleri bolme
// Zaman Karmasikligi: O(n) - liste bir kez taranir
// Alan Karmasikligi: O(1) - sadece sabit sayida isaretci kullanilir
// Aciklama: Kucuk degerler icin bir liste, buyuk/esit degerler icin baska
// bir liste olusturup sonunda bu iki listeyi birbirine baglayoruz.
public class Solution
{
    public ListNode Partition(ListNode bas, int sinir)
    {
        var kucukBas = new ListNode(0);
        var buyukBas = new ListNode(0);

        var kucukKuyruk = kucukBas;
        var buyukKuyruk = buyukBas;

        var simdiki = bas;

        while (simdiki != null)
        {
            if (simdiki.deger < sinir)
            {
                kucukKuyruk.sonraki = simdiki;
                kucukKuyruk = kucukKuyruk.sonraki;
            }
            else
            {
                buyukKuyruk.sonraki = simdiki;
                buyukKuyruk = buyukKuyruk.sonraki;
            }

            simdiki = simdiki.sonraki;
        }

        buyukKuyruk.sonraki = null;
        kucukKuyruk.sonraki = buyukBas.sonraki;

        return kucukBas.sonraki;
    }
}
