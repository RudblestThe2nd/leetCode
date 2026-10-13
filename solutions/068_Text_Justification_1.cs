// 68 - Text Justification - Hard
// Task: Format words into fully justified text lines with a fixed maximum width.
// Official link: https://leetcode.com/problems/text-justification/
// Difficulty: Hard
// Question number: 68
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Greedy satir doldurma + bosluk dagitma (klasik tek gecisli yaklasim)
// Zaman Karmasikligi: O(toplamKarakterSayisi)
// Alan Karmasikligi: O(toplamKarakterSayisi) - sonuc listesi icin
// Aciklama: Kelimeler siraya gore satira eklenir, satir genislik siniri
// asilmadan doldurulur. Satir tamamlaninca kelimeler arasindaki bosluklar
// esit ya da esite yakin dagitilir. Son satir sola hizali birakilir.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> FullJustify(string[] kelimeler, int maksimumGenislik)
    {
        IList<string> sonucListesi = new List<string>();
        int indeks = 0;

        while (indeks < kelimeler.Length)
        {
            int satirBaslangici = indeks;
            int satirUzunlugu = 0;

            while (indeks < kelimeler.Length &&
                   satirUzunlugu + kelimeler[indeks].Length + (indeks - satirBaslangici) <= maksimumGenislik)
            {
                satirUzunlugu += kelimeler[indeks].Length;
                indeks++;
            }

            int kelimeSayisi = indeks - satirBaslangici;
            StringBuilder satirOlusturucu = new StringBuilder();

            bool sonSatirMi = (indeks == kelimeler.Length);

            if (kelimeSayisi == 1 || sonSatirMi)
            {
                for (int sayac = satirBaslangici; sayac < indeks; sayac++)
                {
                    if (sayac > satirBaslangici)
                    {
                        satirOlusturucu.Append(' ');
                    }
                    satirOlusturucu.Append(kelimeler[sayac]);
                }

                while (satirOlusturucu.Length < maksimumGenislik)
                {
                    satirOlusturucu.Append(' ');
                }
            }
            else
            {
                int bosSayisi = kelimeSayisi - 1;
                int toplamBosluk = maksimumGenislik - satirUzunlugu;
                int temelBosluk = toplamBosluk / bosSayisi;
                int fazlaBosluk = toplamBosluk % bosSayisi;

                for (int sayac = satirBaslangici; sayac < indeks; sayac++)
                {
                    satirOlusturucu.Append(kelimeler[sayac]);

                    if (sayac < indeks - 1)
                    {
                        int buAraBosluk = temelBosluk + ((sayac - satirBaslangici) < fazlaBosluk ? 1 : 0);
                        satirOlusturucu.Append(new string(' ', buAraBosluk));
                    }
                }
            }

            sonucListesi.Add(satirOlusturucu.ToString());
        }

        return sonucListesi;
    }
}
