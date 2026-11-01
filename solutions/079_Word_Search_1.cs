// 79 - Word Search - Medium
// Task: Determine whether a word can be formed by moving through adjacent cells in a character grid.
// Official link: https://leetcode.com/problems/word-search/
// Difficulty: Medium
// Question number: 79
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Derinlik oncelikli arama (DFS) ile geriye izleme, ziyaret durumunu
// ayri bir bool matrisinde tutuyoruz. Her hucreden dort yone ilerleyerek kelimenin
// harflerini sirayla eslestirmeye calisiyoruz.
// Zaman Karmasikligi: O(satirSayisi * sutunSayisi * 4^kelimeUzunlugu)
// Alan Karmasikligi: O(satirSayisi * sutunSayisi) (ziyaret matrisi)

public class Solution
{
    public bool Exist(char[][] tahta, string kelime)
    {
        int satirSayisi = tahta.Length;
        int sutunSayisi = tahta[0].Length;
        bool[][] ziyaretEdildi = new bool[satirSayisi][];

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            ziyaretEdildi[satir] = new bool[sutunSayisi];
        }

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (Ara(tahta, kelime, 0, satir, sutun, ziyaretEdildi))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Ara(char[][] tahta, string kelime, int harfIndeksi, int satir, int sutun, bool[][] ziyaretEdildi)
    {
        if (harfIndeksi == kelime.Length)
        {
            return true;
        }

        if (satir < 0 || satir >= tahta.Length || sutun < 0 || sutun >= tahta[0].Length)
        {
            return false;
        }

        if (ziyaretEdildi[satir][sutun] || tahta[satir][sutun] != kelime[harfIndeksi])
        {
            return false;
        }

        ziyaretEdildi[satir][sutun] = true;

        bool bulunduMu = Ara(tahta, kelime, harfIndeksi + 1, satir + 1, sutun, ziyaretEdildi) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir - 1, sutun, ziyaretEdildi) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir, sutun + 1, ziyaretEdildi) ||
                          Ara(tahta, kelime, harfIndeksi + 1, satir, sutun - 1, ziyaretEdildi);

        ziyaretEdildi[satir][sutun] = false;

        return bulunduMu;
    }
}
