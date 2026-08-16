// 12 - Integer to Roman - Medium
// Task: Convert an integer into its Roman numeral representation.
// Official link: https://leetcode.com/problems/integer-to-roman/
// Difficulty: Medium
// Question number: 12
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Gozlu (Greedy) Tablo Esleme - onceden tanimlanmis deger-sembol ciftlerini buyukten kucuge dene.
// Zaman Karmasikligi: O(1) - sabit sayida deger araligi uzerinden gecis (pratikte sabit ust sinir).
// Alan Karmasikligi: O(1) - sabit boyutlu diziler kullanilir.

public class Solution
{
    public string IntToRoman(int num)
    {
        int[] degerler = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] semboller = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        System.Text.StringBuilder sonuc = new System.Text.StringBuilder();
        int kalanSayi = num;

        for (int indeks = 0; indeks < degerler.Length; indeks++)
        {
            while (kalanSayi >= degerler[indeks])
            {
                kalanSayi -= degerler[indeks];
                sonuc.Append(semboller[indeks]);
            }
        }

        return sonuc.ToString();
    }
}
