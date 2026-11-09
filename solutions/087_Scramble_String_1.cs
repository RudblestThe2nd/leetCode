// 87 - Scramble String - Hard
// Task: Determine whether one string can be transformed into another by recursively scrambling substrings.
// Official link: https://leetcode.com/problems/scramble-string/
// Difficulty: Hard
// Question number: 87
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ozyinelemeli (recursive) cozum, sozluk ile ezberleme (memoization)
// Zaman Karmasikligi: O(n^4) - her (i, j, uzunluk) durumu icin n bolme noktasi denenir
// Alan Karmasikligi: O(n^3) - ezberleme sozlugu icin
// Aciklama: Iki dizgeyi belirli bir noktadan boluyoruz; boluk ya duz ya da
// capraz eslesirse alt problemlere ozyinelemeli olarak iniyoruz. Ayni
// (baslangic1, baslangic2, uzunluk) uclusunu tekrar hesaplamamak icin
// sonuclari bir sozlukte saklariz.
public class Solution
{
    private System.Collections.Generic.Dictionary<string, bool> ezberSozluk =
        new System.Collections.Generic.Dictionary<string, bool>();

    public bool IsScramble(string dizge1, string dizge2)
    {
        return Cozum(dizge1, dizge2);
    }

    private bool Cozum(string dizge1, string dizge2)
    {
        if (dizge1 == dizge2)
        {
            return true;
        }

        if (dizge1.Length != dizge2.Length)
        {
            return false;
        }

        string anahtar = dizge1 + "#" + dizge2;
        if (ezberSozluk.TryGetValue(anahtar, out bool onceki))
        {
            return onceki;
        }

        var sayac1 = new int[26];
        var sayac2 = new int[26];

        for (int indeks = 0; indeks < dizge1.Length; indeks++)
        {
            sayac1[dizge1[indeks] - 'a']++;
            sayac2[dizge2[indeks] - 'a']++;
        }

        for (int harf = 0; harf < 26; harf++)
        {
            if (sayac1[harf] != sayac2[harf])
            {
                ezberSozluk[anahtar] = false;
                return false;
            }
        }

        int uzunluk = dizge1.Length;
        bool sonuc = false;

        for (int bolmeNoktasi = 1; bolmeNoktasi < uzunluk && !sonuc; bolmeNoktasi++)
        {
            bool duzEslesme = Cozum(dizge1.Substring(0, bolmeNoktasi), dizge2.Substring(0, bolmeNoktasi)) &&
                               Cozum(dizge1.Substring(bolmeNoktasi), dizge2.Substring(bolmeNoktasi));

            if (duzEslesme)
            {
                sonuc = true;
                continue;
            }

            bool capraz = Cozum(dizge1.Substring(0, bolmeNoktasi), dizge2.Substring(uzunluk - bolmeNoktasi)) &&
                          Cozum(dizge1.Substring(bolmeNoktasi), dizge2.Substring(0, uzunluk - bolmeNoktasi));

            if (capraz)
            {
                sonuc = true;
            }
        }

        ezberSozluk[anahtar] = sonuc;
        return sonuc;
    }
}
