// 91 - Decode Ways - Medium
// Task: Count the number of ways to decode a digit string where numbers map to letters.
// Official link: https://leetcode.com/problems/decode-ways/
// Difficulty: Medium
// Question number: 91
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ozyinelemeli (recursive) cozum, dizi ile ezberleme (memoization)
// Zaman Karmasikligi: O(n) - her indeks icin sonuc bir kez hesaplanir
// Alan Karmasikligi: O(n) - ezber dizisi ve cagri yigini icin
// Aciklama: Belirli bir indeksten itibaren dizgenin kac farkli sekilde
// cozulebilecegini ozyinelemeli olarak hesapliyoruz. Ayni indeksten tekrar
// baslamamak icin sonuclari bir ezber dizisinde saklayoruz.
public class Solution
{
    private int[] ezberDizisi;

    public int NumDecodings(string dizge)
    {
        int uzunluk = dizge.Length;
        ezberDizisi = new int[uzunluk + 1];

        for (int indeks = 0; indeks <= uzunluk; indeks++)
        {
            ezberDizisi[indeks] = -1;
        }

        return Cozum(dizge, 0);
    }

    private int Cozum(string dizge, int indeks)
    {
        if (indeks == dizge.Length)
        {
            return 1;
        }

        if (dizge[indeks] == '0')
        {
            return 0;
        }

        if (ezberDizisi[indeks] != -1)
        {
            return ezberDizisi[indeks];
        }

        int sonuc = Cozum(dizge, indeks + 1);

        if (indeks + 1 < dizge.Length)
        {
            int ikiliDeger = (dizge[indeks] - '0') * 10 + (dizge[indeks + 1] - '0');
            if (ikiliDeger >= 10 && ikiliDeger <= 26)
            {
                sonuc += Cozum(dizge, indeks + 2);
            }
        }

        ezberDizisi[indeks] = sonuc;
        return sonuc;
    }
}
