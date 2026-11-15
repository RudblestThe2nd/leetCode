// 93 - Restore IP Addresses - Medium
// Task: Return all valid IP addresses that can be formed by inserting three dots into a digit string.
// Official link: https://leetcode.com/problems/restore-ip-addresses/
// Difficulty: Medium
// Question number: 93
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ic ice dort for dongusiyle (brute force / kaba kuvvet) tum bolme noktalarini deneme.
// Dort parcanin bitis indekslerini sirayla deneyip, uzunluk toplami dogru ise kontrol eder.
// Zaman Karmasikligi: O(uzunluk^3) - 3 kesme noktasi icin ic ice donguler (4. parca kalanla belirlenir).
// Alan Karmasikligi: O(uzunluk) - sonuc listesi ve gecici dize birlestirme icin.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> RestoreIpAddresses(string dizi)
    {
        var sonuc = new List<string>();
        int uzunluk = dizi.Length;

        for (int birinci = 1; birinci <= 3 && birinci < uzunluk; birinci++)
        {
            for (int ikinci = birinci + 1; ikinci <= birinci + 3 && ikinci < uzunluk; ikinci++)
            {
                for (int ucuncu = ikinci + 1; ucuncu <= ikinci + 3 && ucuncu < uzunluk; ucuncu++)
                {
                    if (uzunluk - ucuncu > 3)
                    {
                        continue;
                    }

                    string parca1 = dizi.Substring(0, birinci);
                    string parca2 = dizi.Substring(birinci, ikinci - birinci);
                    string parca3 = dizi.Substring(ikinci, ucuncu - ikinci);
                    string parca4 = dizi.Substring(ucuncu);

                    if (GecerliMi(parca1) && GecerliMi(parca2) && GecerliMi(parca3) && GecerliMi(parca4))
                    {
                        var yeniAdres = new StringBuilder();
                        yeniAdres.Append(parca1).Append('.').Append(parca2).Append('.').Append(parca3).Append('.').Append(parca4);
                        sonuc.Add(yeniAdres.ToString());
                    }
                }
            }
        }

        return sonuc;
    }

    private bool GecerliMi(string parca)
    {
        if (parca.Length == 0 || parca.Length > 3)
        {
            return false;
        }

        if (parca.Length > 1 && parca[0] == '0')
        {
            return false;
        }

        int deger = int.Parse(parca);

        return deger <= 255;
    }
}
