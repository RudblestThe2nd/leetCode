// 8 - String to Integer (atoi) - Medium
// Task: Parse a string into a 32-bit signed integer following common atoi-style rules for spaces, signs, and invalid characters.
// Official link: https://leetcode.com/problems/string-to-integer-atoi/
// Difficulty: Medium
// Question number: 8
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Durum Makinesi (State Machine) - dizeyi durumlar arasinda gecis yaparak isle (bosluk, isaret, basamak, bitis).
// Zaman Karmasikligi: O(n) - her karakter icin sabit sayida durum kontrolu.
// Alan Karmasikligi: O(1) - sadece sabit sayida degisken kullanilir.

public class Solution
{
    private enum Durum
    {
        Baslangic,
        Isaret,
        Basamak,
        Bitis
    }

    public int MyAtoi(string s)
    {
        Durum mevcutDurum = Durum.Baslangic;
        int isaret = 1;
        long biriktirilenDeger = 0;

        foreach (char karakter in s)
        {
            if (mevcutDurum == Durum.Bitis)
            {
                break;
            }

            if (mevcutDurum == Durum.Baslangic)
            {
                if (karakter == ' ')
                {
                    continue;
                }
                else if (karakter == '+' || karakter == '-')
                {
                    isaret = (karakter == '-') ? -1 : 1;
                    mevcutDurum = Durum.Isaret;
                }
                else if (karakter >= '0' && karakter <= '9')
                {
                    biriktirilenDeger = karakter - '0';
                    mevcutDurum = Durum.Basamak;
                }
                else
                {
                    mevcutDurum = Durum.Bitis;
                }
            }
            else if (mevcutDurum == Durum.Isaret || mevcutDurum == Durum.Basamak)
            {
                if (karakter >= '0' && karakter <= '9')
                {
                    biriktirilenDeger = biriktirilenDeger * 10 + (karakter - '0');
                    mevcutDurum = Durum.Basamak;

                    if (isaret == 1 && biriktirilenDeger > int.MaxValue)
                    {
                        return int.MaxValue;
                    }

                    if (isaret == -1 && -biriktirilenDeger < int.MinValue)
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    mevcutDurum = Durum.Bitis;
                }
            }
        }

        return (int)(biriktirilenDeger * isaret);
    }
}
