// 67 - Add Binary - Easy
// Task: Add two binary strings and return their sum as a binary string.
// Official link: https://leetcode.com/problems/add-binary/
// Difficulty: Easy
// Question number: 67
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki isaretciyle sondan basa elle toplama (StringBuilder ile)
// Zaman Karmasikligi: O(max(n, m)) - n ve m iki dizinin uzunlugu
// Alan Karmasikligi: O(max(n, m)) - sonuc dizesi icin
// Aciklama: Her iki dizenin sonundan baslanarak, elde tutulan tasima (carry)
// degeriyle birlikte basamaklar toplanir. Sonuc ters sirada olusturulur ve
// en son ters cevrilir.

using System.Text;

public class Solution
{
    public string AddBinary(string birinciSayi, string ikinciSayi)
    {
        int birinciIsaretci = birinciSayi.Length - 1;
        int ikinciIsaretci = ikinciSayi.Length - 1;

        int tasima = 0;
        StringBuilder sonucOlusturucu = new StringBuilder();

        while (birinciIsaretci >= 0 || ikinciIsaretci >= 0 || tasima > 0)
        {
            int toplam = tasima;

            if (birinciIsaretci >= 0)
            {
                toplam += birinciSayi[birinciIsaretci] - '0';
                birinciIsaretci--;
            }

            if (ikinciIsaretci >= 0)
            {
                toplam += ikinciSayi[ikinciIsaretci] - '0';
                ikinciIsaretci--;
            }

            sonucOlusturucu.Append(toplam % 2);
            tasima = toplam / 2;
        }

        char[] sonucDizisi = sonucOlusturucu.ToString().ToCharArray();
        System.Array.Reverse(sonucDizisi);

        return new string(sonucDizisi);
    }
}
