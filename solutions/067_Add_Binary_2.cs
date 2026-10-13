// 67 - Add Binary - Easy
// Task: Add two binary strings and return their sum as a binary string.
// Official link: https://leetcode.com/problems/add-binary/
// Difficulty: Easy
// Question number: 67
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: BigInteger tabanli cevirme yaklasimi
// Zaman Karmasikligi: O(n + m) - n ve m iki dizinin uzunlugu (parse ve toplama)
// Alan Karmasikligi: O(n + m) - BigInteger ve sonuc metni icin
// Aciklama: Her iki ikilik (binary) metin, taban 2 kullanilarak elle
// BigInteger'a cevrilir, ardindan toplanir. Sonuc BigInteger'dan tekrar
// ikilik tabanda bir metne cevrilir.

using System.Numerics;
using System.Text;

public class Solution
{
    public string AddBinary(string birinciSayi, string ikinciSayi)
    {
        BigInteger birinciDeger = IkilikMetniSayiyaCevir(birinciSayi);
        BigInteger ikinciDeger = IkilikMetniSayiyaCevir(ikinciSayi);

        BigInteger toplamDeger = birinciDeger + ikinciDeger;

        return SayiyiIkilikMetneCevir(toplamDeger);
    }

    private BigInteger IkilikMetniSayiyaCevir(string metin)
    {
        BigInteger deger = 0;

        foreach (char karakter in metin)
        {
            deger = deger * 2 + (karakter - '0');
        }

        return deger;
    }

    private string SayiyiIkilikMetneCevir(BigInteger sayi)
    {
        if (sayi == 0)
        {
            return "0";
        }

        StringBuilder metinOlusturucu = new StringBuilder();

        while (sayi > 0)
        {
            BigInteger kalan = sayi % 2;
            metinOlusturucu.Insert(0, kalan.ToString());
            sayi = sayi / 2;
        }

        return metinOlusturucu.ToString();
    }
}
