// 10 - Regular Expression Matching - Hard
// Task: Implement regular expression matching for a full string using '.' and '*' pattern rules.
// Official link: https://leetcode.com/problems/regular-expression-matching/
// Difficulty: Hard
// Question number: 10
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Dinamik Programlama (Bottom-Up DP) - iki boyutlu tablo ile tum alt problemleri bastan hesapla.
// Zaman Karmasikligi: O(n*m) - tablo boyutu kadar hesaplama.
// Alan Karmasikligi: O(n*m) - iki boyutlu dp tablosu.

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int metinUzunlugu = s.Length;
        int desenUzunlugu = p.Length;

        bool[,] dpTablosu = new bool[metinUzunlugu + 1, desenUzunlugu + 1];
        dpTablosu[0, 0] = true;

        for (int desenIndeksi = 1; desenIndeksi <= desenUzunlugu; desenIndeksi++)
        {
            if (p[desenIndeksi - 1] == '*' && desenIndeksi >= 2)
            {
                dpTablosu[0, desenIndeksi] = dpTablosu[0, desenIndeksi - 2];
            }
        }

        for (int metinIndeksi = 1; metinIndeksi <= metinUzunlugu; metinIndeksi++)
        {
            for (int desenIndeksi = 1; desenIndeksi <= desenUzunlugu; desenIndeksi++)
            {
                char desenKarakteri = p[desenIndeksi - 1];

                if (desenKarakteri == '*')
                {
                    char oncekiDesenKarakteri = p[desenIndeksi - 2];

                    bool sifirTekrar = dpTablosu[metinIndeksi, desenIndeksi - 2];

                    bool karakterUyumlu = oncekiDesenKarakteri == '.' || oncekiDesenKarakteri == s[metinIndeksi - 1];
                    bool birVeyaDahaFazlaTekrar = karakterUyumlu && dpTablosu[metinIndeksi - 1, desenIndeksi];

                    dpTablosu[metinIndeksi, desenIndeksi] = sifirTekrar || birVeyaDahaFazlaTekrar;
                }
                else if (desenKarakteri == '.' || desenKarakteri == s[metinIndeksi - 1])
                {
                    dpTablosu[metinIndeksi, desenIndeksi] = dpTablosu[metinIndeksi - 1, desenIndeksi - 1];
                }
                else
                {
                    dpTablosu[metinIndeksi, desenIndeksi] = false;
                }
            }
        }

        return dpTablosu[metinUzunlugu, desenUzunlugu];
    }
}
