// 45 - Jump Game II - Medium
// Task: Return the minimum number of jumps needed to reach the last index of an array.
// Official link: https://leetcode.com/problems/jump-game-ii/
// Difficulty: Medium
// Question number: 45
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Ac Gozlu (Greedy) Katman Bazli Genisleme
// Su anki sicramayla ulasilabilecek en uzak noktayi takip ederiz.
// Mevcut katmanin sinirina ulastigimizda sicrama sayacini bir artirir
// ve bir sonraki katmanin sinirina geceriz. BFS'e benzer bir mantiktir.
// Zaman Karmasikligi: O(dizi.Uzunluk)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int Jump(int[] dizi)
    {
        int sicramaSayisi = 0;

        int suankiSinir = 0;
        int enUzakErisim = 0;

        for (int indeks = 0; indeks < dizi.Length - 1; indeks++)
        {
            int olasiErisim = indeks + dizi[indeks];

            if (olasiErisim > enUzakErisim)
            {
                enUzakErisim = olasiErisim;
            }

            if (indeks == suankiSinir)
            {
                sicramaSayisi++;
                suankiSinir = enUzakErisim;
            }
        }

        return sicramaSayisi;
    }
}
