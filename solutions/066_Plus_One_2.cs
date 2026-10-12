// 66 - Plus One - Easy
// Task: Add one to a non-negative integer represented by an array of digits.
// Official link: https://leetcode.com/problems/plus-one/
// Difficulty: Easy
// Question number: 66
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: BigInteger'a cevirip bir ekleme, sonra tekrar diziye cevirme
// Zaman Karmasikligi: O(n) - n basamak sayisi
// Alan Karmasikligi: O(n) - metin ve BigInteger gosterimi icin
// Aciklama: Basamaklar once bir metne birlestirilir, bu metin BigInteger'a
// cevrilir (int dizisi cok uzun olabileceginden normal int/long yetersiz
// kalabilir). Bir eklenir, sonuc tekrar metne, oradan da basamak dizisine
// donusturulur.

using System.Numerics;
using System.Text;

public class Solution
{
    public int[] PlusOne(int[] basamaklar)
    {
        StringBuilder metinOlusturucu = new StringBuilder();

        foreach (int basamak in basamaklar)
        {
            metinOlusturucu.Append(basamak);
        }

        BigInteger sayi = BigInteger.Parse(metinOlusturucu.ToString());
        sayi = sayi + 1;

        string sonucMetni = sayi.ToString();
        int[] sonucDizisi = new int[sonucMetni.Length];

        for (int indeks = 0; indeks < sonucMetni.Length; indeks++)
        {
            sonucDizisi[indeks] = sonucMetni[indeks] - '0';
        }

        return sonucDizisi;
    }
}
