// 27 - Remove Element - Easy
// Task: Remove every occurrence of a given value from an array in place and return the new logical length.
// Official link: https://leetcode.com/problems/remove-element/
// Difficulty: Easy
// Question number: 27
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki Isaretci - Sondan Yer Degistirme (Minimum Yazma)
// Zaman Karmasikligi: O(n) - her eleman en fazla bir defa islenir
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz
// Turkce aciklama: Sol isaretci basdan, sag isaretci sondan baslar. Silinecek deger
// bulundugunda, dizinin sonundaki eleman o pozisyona tasinir ve sag isaretci kisaltilir.

public class Solution
{
    public int RemoveElement(int[] sayilar, int deger)
    {
        int solIsaretci = 0;
        int sagUzunluk = sayilar.Length;

        while (solIsaretci < sagUzunluk)
        {
            if (sayilar[solIsaretci] == deger)
            {
                sagUzunluk--;
                sayilar[solIsaretci] = sayilar[sagUzunluk];
            }
            else
            {
                solIsaretci++;
            }
        }

        return sagUzunluk;
    }
}
