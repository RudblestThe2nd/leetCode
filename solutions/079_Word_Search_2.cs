// 79 - Word Search - Medium
// Task: Determine whether a word can be formed by moving through adjacent cells in a character grid.
// Official link: https://leetcode.com/problems/word-search/
// Difficulty: Medium
// Question number: 79
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Derinlik oncelikli arama, ancak ziyaret icin ayri bir matris kullanmiyoruz.
// Ziyaret edilen hucreyi gecici olarak ozel bir karaktere ('#') cevirip geri donuste
// eski harfini geri yaziyoruz. Bu, alan kullanimini ziyaret matrisinden kurtarir.
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi * 4^kelimeUzunlugu)
// Alan Karmasikligi: O(kelimeUzunlugu) (sadece cagri yiginlarindan gelen derinlik)

public class Solution
{
    public bool Exist(char[][] tahta, string kelime)
    {
        int satirSayisi = tahta.Length;
        int sutunSayisi = tahta[0].Length;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (Ara(tahta, kelime, 0, satir, sutun))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Ara(char[][] tahta, string kelime, int harfIndeksi, int satir, int sutun)
    {
        if (harfIndeksi == kelime.Length)
        {
            return true;
        }

        if (satir < 0 || satir >= tahta.Length || sutun < 0 || sutun >= tahta[0].Length)
        {
            return false;
        }

        char orijinalHarf = tahta[satir][sutun];

        if (orijinalHarf != kelime[harfIndeksi])
        {
            return false;
        }

        tahta[satir][sutun] = '#';

        bool bulunduMu = Ara(tahta, kelime, harfIndeksi + 1, satir + 1, sutun) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir - 1, sutun) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir, sutun + 1) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir, sutun - 1);

        tahta[satir][sutun] = orijinalHarf;

        return bulunduMu;
    }
}
