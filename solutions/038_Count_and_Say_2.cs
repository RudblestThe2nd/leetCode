// 38 - Count and Say - Medium
// Task: Generate the nth term of the count-and-say sequence.
// Official link: https://leetcode.com/problems/count-and-say/
// Difficulty: Medium
// Question number: 38
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Recursive yaklasim
// n. terimi bulmak icin once (n-1). terimi recursive olarak hesapliyoruz,
// sonra o terimi "oku" ve sonucu uret. Taban durumu n == 1 icin "1" donuyor.
// Zaman Karmasikligi: O(n * m) (n adim, m ortalama string uzunlugu)
// Alan Karmasikligi: O(n * m) (recursion stack + her seviyede olusan stringler)

using System.Text;

public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
        {
            return "1";
        }

        string oncekiTerim = CountAndSay(n - 1);

        return TerimiOku(oncekiTerim);
    }

    private string TerimiOku(string terim)
    {
        StringBuilder sonuc = new StringBuilder();
        int indeks = 0;

        while (indeks < terim.Length)
        {
            char karakter = terim[indeks];
            int sayac = 0;

            while (indeks < terim.Length && terim[indeks] == karakter)
            {
                sayac++;
                indeks++;
            }

            sonuc.Append(sayac);
            sonuc.Append(karakter);
        }

        return sonuc.ToString();
    }
}
