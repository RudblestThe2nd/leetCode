// 66 - Plus One - Easy
// Task: Add one to a non-negative integer represented by an array of digits.
// Official link: https://leetcode.com/problems/plus-one/
// Difficulty: Easy
// Question number: 66
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Sondan basa elle tasima (carry) islemi ile
// Zaman Karmasikligi: O(n) - n basamak sayisi (en kotu durumda n+1)
// Alan Karmasikligi: O(n) - sonuc dizisi icin
// Aciklama: En son basamaktan baslanarak bir eklenir. Basamak 9 ise 0 olur ve
// tasima bir onceki basamaga gecer. Tum basamaklar 9 ise en basa yeni bir
// basamak (1) eklenir.

public class Solution
{
    public int[] PlusOne(int[] basamaklar)
    {
        int uzunluk = basamaklar.Length;

        for (int indeks = uzunluk - 1; indeks >= 0; indeks--)
        {
            if (basamaklar[indeks] < 9)
            {
                basamaklar[indeks]++;
                return basamaklar;
            }

            basamaklar[indeks] = 0;
        }

        int[] yeniDizi = new int[uzunluk + 1];
        yeniDizi[0] = 1;

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            yeniDizi[indeks + 1] = basamaklar[indeks];
        }

        return yeniDizi;
    }
}
