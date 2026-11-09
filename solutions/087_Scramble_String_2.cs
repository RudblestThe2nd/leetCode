// 87 - Scramble String - Hard
// Task: Determine whether one string can be transformed into another by recursively scrambling substrings.
// Official link: https://leetcode.com/problems/scramble-string/
// Difficulty: Hard
// Question number: 87
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Asagidan yukariya (bottom-up) dinamik programlama, 3 boyutlu tablo
// Zaman Karmasikligi: O(n^4) - uzunluk, iki baslangic indeksi ve bolme noktasi dongusu
// Alan Karmasikligi: O(n^3) - durum tablosu icin
// Aciklama: durum[uzunluk][baslangic1][baslangic2] degeri, dizge1'in
// baslangic1'den ve dizge2'nin baslangic2'den baslayan uzunluk karakterlik
// parcalarinin birbirinin karistirilmisi olup olmadigini tutar. Kucuk
// uzunluklardan basliyip buyuk uzunluklara dogru tabloyu dolduruyoruz.
public class Solution
{
    public bool IsScramble(string dizge1, string dizge2)
    {
        int uzunlukToplam = dizge1.Length;

        if (uzunlukToplam != dizge2.Length)
        {
            return false;
        }

        var durum = new bool[uzunlukToplam + 1][][];
        for (int uzunluk = 0; uzunluk <= uzunlukToplam; uzunluk++)
        {
            durum[uzunluk] = new bool[uzunlukToplam][];
            for (int baslangic1 = 0; baslangic1 < uzunlukToplam; baslangic1++)
            {
                durum[uzunluk][baslangic1] = new bool[uzunlukToplam];
            }
        }

        for (int baslangic1 = 0; baslangic1 < uzunlukToplam; baslangic1++)
        {
            for (int baslangic2 = 0; baslangic2 < uzunlukToplam; baslangic2++)
            {
                durum[1][baslangic1][baslangic2] = dizge1[baslangic1] == dizge2[baslangic2];
            }
        }

        for (int uzunluk = 2; uzunluk <= uzunlukToplam; uzunluk++)
        {
            for (int baslangic1 = 0; baslangic1 + uzunluk <= uzunlukToplam; baslangic1++)
            {
                for (int baslangic2 = 0; baslangic2 + uzunluk <= uzunlukToplam; baslangic2++)
                {
                    bool sonuc = false;

                    for (int bolmeNoktasi = 1; bolmeNoktasi < uzunluk && !sonuc; bolmeNoktasi++)
                    {
                        bool duzEslesme = durum[bolmeNoktasi][baslangic1][baslangic2] &&
                                           durum[uzunluk - bolmeNoktasi][baslangic1 + bolmeNoktasi][baslangic2 + bolmeNoktasi];

                        bool caprazEslesme = durum[bolmeNoktasi][baslangic1][baslangic2 + uzunluk - bolmeNoktasi] &&
                                             durum[uzunluk - bolmeNoktasi][baslangic1 + bolmeNoktasi][baslangic2];

                        if (duzEslesme || caprazEslesme)
                        {
                            sonuc = true;
                        }
                    }

                    durum[uzunluk][baslangic1][baslangic2] = sonuc;
                }
            }
        }

        return durum[uzunlukToplam][0][0];
    }
}
