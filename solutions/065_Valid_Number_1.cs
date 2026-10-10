// 65 - Valid Number - Hard
// Task: Determine whether a string is a valid decimal/scientific number.
// Official link: https://leetcode.com/problems/valid-number/
// Difficulty: Hard
// Question number: 65
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Durum makinesi (finite state machine, karakter karakter islenerek)
// Zaman Karmasikligi: O(n) - n metnin uzunlugu
// Alan Karmasikligi: O(1)
// Aciklama: Karakterler tek tek gezilir, her karaktere gore rakam mi, nokta mi,
// isaret mi yoksa e/E mi oldugu belirlenir ve buna gore bayraklar guncellenir.
// Sonunda en az bir rakam gorulmus olmasi gerekir.

public class Solution
{
    public bool IsNumber(string metin)
    {
        bool rakamGorundu = false;
        bool noktaGorundu = false;
        bool ustelGorundu = false;
        bool ustelSonrasiRakamGorundu = false;

        for (int indeks = 0; indeks < metin.Length; indeks++)
        {
            char karakter = metin[indeks];

            if (char.IsDigit(karakter))
            {
                rakamGorundu = true;
                if (ustelGorundu)
                {
                    ustelSonrasiRakamGorundu = true;
                }
            }
            else if (karakter == '+' || karakter == '-')
            {
                bool oncekiKarakterUstelMi = indeks > 0 && (metin[indeks - 1] == 'e' || metin[indeks - 1] == 'E');

                if (indeks != 0 && !oncekiKarakterUstelMi)
                {
                    return false;
                }
            }
            else if (karakter == '.')
            {
                if (noktaGorundu || ustelGorundu)
                {
                    return false;
                }
                noktaGorundu = true;
            }
            else if (karakter == 'e' || karakter == 'E')
            {
                if (ustelGorundu || !rakamGorundu)
                {
                    return false;
                }
                ustelGorundu = true;
            }
            else
            {
                return false;
            }
        }

        if (ustelGorundu)
        {
            return rakamGorundu && ustelSonrasiRakamGorundu;
        }

        return rakamGorundu;
    }
}
