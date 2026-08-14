// 10 - Regular Expression Matching - Hard
// Task: Implement regular expression matching for a full string using '.' and '*' pattern rules.
// Official link: https://leetcode.com/problems/regular-expression-matching/
// Difficulty: Hard
// Question number: 10
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (Ozyinelemeli) Cozum - deseni ve metni karakter karakter ozyinelemeli olarak esletir.
// Zaman Karmasikligi: O(2^(n+m)) en kotu durumda - alt cagrilar ustel olarak buyuyebilir.
// Alan Karmasikligi: O(n+m) - cagri yiginin derinligi.

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        return Eslestir(s, 0, p, 0);
    }

    private bool Eslestir(string metin, int metinIndeksi, string desen, int desenIndeksi)
    {
        if (desenIndeksi == desen.Length)
        {
            return metinIndeksi == metin.Length;
        }

        bool ilkKarakterEslesti = metinIndeksi < metin.Length &&
            (desen[desenIndeksi] == metin[metinIndeksi] || desen[desenIndeksi] == '.');

        if (desenIndeksi + 1 < desen.Length && desen[desenIndeksi + 1] == '*')
        {
            bool sifirTekrar = Eslestir(metin, metinIndeksi, desen, desenIndeksi + 2);
            bool birVeyaDahaFazlaTekrar = ilkKarakterEslesti && Eslestir(metin, metinIndeksi + 1, desen, desenIndeksi);

            return sifirTekrar || birVeyaDahaFazlaTekrar;
        }

        return ilkKarakterEslesti && Eslestir(metin, metinIndeksi + 1, desen, desenIndeksi + 1);
    }
}
