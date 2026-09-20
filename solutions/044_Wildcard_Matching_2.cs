// 44 - Wildcard Matching - Hard
// Task: Implement wildcard pattern matching for a full string using '?' and '*' rules.
// Official link: https://leetcode.com/problems/wildcard-matching/
// Difficulty: Hard
// Question number: 44
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Ac Gozlu (Greedy) Iki Isaretci ve Geri Donus Noktasi
// Metin ve deseni ayni anda tarariz. Bir '*' gordugumuzde konumunu
// isaretleriz. Eslesme basarisiz olursa, en son '*' isaretine geri
// donup bir karakter daha yutarak yeniden deneriz. Ekstra tablo
// olusturmadan sabit alanla calisir.
// Zaman Karmasikligi: O(metin.Uzunluk * desen.Uzunluk) (en kotu durum)
// Alan Karmasikligi: O(1)

public class Solution
{
    public bool IsMatch(string metin, string desen)
    {
        int indeksMetin = 0;
        int indeksDesen = 0;

        int sonYildizKonumu = -1;
        int eslesenMetinKonumu = -1;

        while (indeksMetin < metin.Length)
        {
            if (indeksDesen < desen.Length &&
                (desen[indeksDesen] == '?' || desen[indeksDesen] == metin[indeksMetin]))
            {
                indeksMetin++;
                indeksDesen++;
            }
            else if (indeksDesen < desen.Length && desen[indeksDesen] == '*')
            {
                sonYildizKonumu = indeksDesen;
                eslesenMetinKonumu = indeksMetin;
                indeksDesen++;
            }
            else if (sonYildizKonumu != -1)
            {
                indeksDesen = sonYildizKonumu + 1;
                eslesenMetinKonumu++;
                indeksMetin = eslesenMetinKonumu;
            }
            else
            {
                return false;
            }
        }

        while (indeksDesen < desen.Length && desen[indeksDesen] == '*')
        {
            indeksDesen++;
        }

        return indeksDesen == desen.Length;
    }
}
