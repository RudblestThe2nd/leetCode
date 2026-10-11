// 65 - Valid Number - Hard
// Task: Determine whether a string is a valid decimal/scientific number.
// Official link: https://leetcode.com/problems/valid-number/
// Difficulty: Hard
// Question number: 65
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki asamali parse/split yaklasimi (Regex kullanilmadan, once
// mantissa ve eksponent kismi ayrilir, sonra her biri manuel kontrol edilir)
// Zaman Karmasikligi: O(n) - n metnin uzunlugu
// Alan Karmasikligi: O(n) - alt dizeler (substring) icin
// Aciklama: Metin once 'e' veya 'E' karakterine gore ikiye bolunur: mantissa
// ve eksponent kismi. Mantissa kismi isaret + rakamlar + tek nokta seklinde,
// eksponent kismi ise isaret + rakamlar seklinde ayri fonksiyonlarla dogrulanir.

public class Solution
{
    public bool IsNumber(string metin)
    {
        int ustelKonumu = -1;

        for (int indeks = 0; indeks < metin.Length; indeks++)
        {
            if (metin[indeks] == 'e' || metin[indeks] == 'E')
            {
                if (ustelKonumu != -1)
                {
                    return false;
                }
                ustelKonumu = indeks;
            }
        }

        if (ustelKonumu == -1)
        {
            return MantisaGecerliMi(metin);
        }

        string mantisaKismi = metin.Substring(0, ustelKonumu);
        string ekponentKismi = metin.Substring(ustelKonumu + 1);

        return MantisaGecerliMi(mantisaKismi) && TamsayiGecerliMi(ekponentKismi);
    }

    private bool MantisaGecerliMi(string parca)
    {
        if (parca.Length == 0)
        {
            return false;
        }

        int baslangic = 0;
        if (parca[0] == '+' || parca[0] == '-')
        {
            baslangic = 1;
        }

        bool rakamGorundu = false;
        bool noktaGorundu = false;

        for (int indeks = baslangic; indeks < parca.Length; indeks++)
        {
            char karakter = parca[indeks];

            if (char.IsDigit(karakter))
            {
                rakamGorundu = true;
            }
            else if (karakter == '.' && !noktaGorundu)
            {
                noktaGorundu = true;
            }
            else
            {
                return false;
            }
        }

        return rakamGorundu;
    }

    private bool TamsayiGecerliMi(string parca)
    {
        if (parca.Length == 0)
        {
            return false;
        }

        int baslangic = 0;
        if (parca[0] == '+' || parca[0] == '-')
        {
            baslangic = 1;
        }

        if (baslangic == parca.Length)
        {
            return false;
        }

        for (int indeks = baslangic; indeks < parca.Length; indeks++)
        {
            if (!char.IsDigit(parca[indeks]))
            {
                return false;
            }
        }

        return true;
    }
}
