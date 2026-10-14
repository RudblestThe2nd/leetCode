// 68 - Text Justification - Hard
// Task: Format words into fully justified text lines with a fixed maximum width.
// Official link: https://leetcode.com/problems/text-justification/
// Difficulty: Hard
// Question number: 68
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iki asamali yaklasim (once kelimeler satirlara ayrilir, sonra her
// satir ayri bir fonksiyonla formatlanir)
// Zaman Karmasikligi: O(toplamKarakterSayisi)
// Alan Karmasikligi: O(toplamKarakterSayisi) - satir gruplari ve sonuc icin
// Aciklama: Ilk asamada kelimeler, genislik sinirini asmayacak sekilde
// kelime gruplarina (satirlara) bolunur. Ikinci asamada her grup, ayri bir
// yardimci fonksiyon araciligiyla ya tam hizali ya da sola hizali metne
// cevrilir.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> FullJustify(string[] kelimeler, int maksimumGenislik)
    {
        List<List<string>> satirGruplari = KelimeleriSatirlaraAyir(kelimeler, maksimumGenislik);

        IList<string> sonucListesi = new List<string>();

        for (int satirIndeks = 0; satirIndeks < satirGruplari.Count; satirIndeks++)
        {
            bool sonSatirMi = (satirIndeks == satirGruplari.Count - 1);
            string formatliSatir = SatiriFormatla(satirGruplari[satirIndeks], maksimumGenislik, sonSatirMi);
            sonucListesi.Add(formatliSatir);
        }

        return sonucListesi;
    }

    private List<List<string>> KelimeleriSatirlaraAyir(string[] kelimeler, int maksimumGenislik)
    {
        List<List<string>> gruplar = new List<List<string>>();
        List<string> guncelGrup = new List<string>();
        int guncelUzunluk = 0;

        foreach (string kelime in kelimeler)
        {
            int eklenecekUzunluk = kelime.Length + (guncelGrup.Count > 0 ? 1 : 0);

            if (guncelUzunluk + eklenecekUzunluk > maksimumGenislik)
            {
                gruplar.Add(guncelGrup);
                guncelGrup = new List<string>();
                guncelUzunluk = 0;
                eklenecekUzunluk = kelime.Length;
            }

            guncelGrup.Add(kelime);
            guncelUzunluk += eklenecekUzunluk;
        }

        if (guncelGrup.Count > 0)
        {
            gruplar.Add(guncelGrup);
        }

        return gruplar;
    }

    private string SatiriFormatla(List<string> satirKelimeleri, int maksimumGenislik, bool sonSatirMi)
    {
        StringBuilder satirOlusturucu = new StringBuilder();
        int kelimeSayisi = satirKelimeleri.Count;

        if (kelimeSayisi == 1 || sonSatirMi)
        {
            satirOlusturucu.Append(string.Join(" ", satirKelimeleri));

            while (satirOlusturucu.Length < maksimumGenislik)
            {
                satirOlusturucu.Append(' ');
            }

            return satirOlusturucu.ToString();
        }

        int harfToplami = 0;
        foreach (string kelime in satirKelimeleri)
        {
            harfToplami += kelime.Length;
        }

        int bosSayisi = kelimeSayisi - 1;
        int toplamBosluk = maksimumGenislik - harfToplami;
        int temelBosluk = toplamBosluk / bosSayisi;
        int fazlaBosluk = toplamBosluk % bosSayisi;

        for (int sayac = 0; sayac < kelimeSayisi; sayac++)
        {
            satirOlusturucu.Append(satirKelimeleri[sayac]);

            if (sayac < kelimeSayisi - 1)
            {
                int buAraBosluk = temelBosluk + (sayac < fazlaBosluk ? 1 : 0);
                satirOlusturucu.Append(new string(' ', buAraBosluk));
            }
        }

        return satirOlusturucu.ToString();
    }
}
