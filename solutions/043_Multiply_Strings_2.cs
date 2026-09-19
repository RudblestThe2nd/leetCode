// 43 - Multiply Strings - Medium
// Task: Multiply two non-negative integers represented as strings and return the product as a string.
// Official link: https://leetcode.com/problems/multiply-strings/
// Difficulty: Medium
// Question number: 43
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Toplama tabanli tekrarli ekleme (Repeated String Addition)
// sayi2'nin her basamagi icin sayi1'i tek basamakla carpip, kaydirarak
// bir ara toplam elde ederiz, sonra bu ara toplamlari string toplama
// fonksiyonuyla birbirine ekleriz. Elle carpma yerine elle toplama kullanilir.
// Zaman Karmasikligi: O(sayi1.Uzunluk * sayi2.Uzunluk)
// Alan Karmasikligi: O(sayi1.Uzunluk + sayi2.Uzunluk)

public class Solution
{
    public string Multiply(string sayi1, string sayi2)
    {
        if (sayi1 == "0" || sayi2 == "0")
        {
            return "0";
        }

        string sonuc = "0";

        int uzunluk2 = sayi2.Length;

        for (int j = uzunluk2 - 1; j >= 0; j--)
        {
            int rakam2 = sayi2[j] - '0';

            string araToplam = CarpTekBasamak(sayi1, rakam2);

            int kaydirmaSayisi = uzunluk2 - 1 - j;

            for (int k = 0; k < kaydirmaSayisi; k++)
            {
                araToplam += "0";
            }

            sonuc = StringleriTopla(sonuc, araToplam);
        }

        return sonuc;
    }

    private string CarpTekBasamak(string sayi, int rakam)
    {
        if (rakam == 0)
        {
            return "0";
        }

        System.Text.StringBuilder tampon = new System.Text.StringBuilder();

        int elde = 0;

        for (int i = sayi.Length - 1; i >= 0; i--)
        {
            int basamak = sayi[i] - '0';

            int carpim = basamak * rakam + elde;

            tampon.Insert(0, carpim % 10);

            elde = carpim / 10;
        }

        if (elde > 0)
        {
            tampon.Insert(0, elde);
        }

        return tampon.ToString();
    }

    private string StringleriTopla(string ilk, string ikinci)
    {
        System.Text.StringBuilder tampon = new System.Text.StringBuilder();

        int indeks1 = ilk.Length - 1;
        int indeks2 = ikinci.Length - 1;

        int elde = 0;

        while (indeks1 >= 0 || indeks2 >= 0 || elde > 0)
        {
            int deger1 = indeks1 >= 0 ? ilk[indeks1] - '0' : 0;
            int deger2 = indeks2 >= 0 ? ikinci[indeks2] - '0' : 0;

            int toplam = deger1 + deger2 + elde;

            tampon.Insert(0, toplam % 10);

            elde = toplam / 10;

            indeks1--;
            indeks2--;
        }

        return tampon.ToString();
    }
}
