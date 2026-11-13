// 91 - Decode Ways - Medium
// Task: Count the number of ways to decode a digit string where numbers map to letters.
// Official link: https://leetcode.com/problems/decode-ways/
// Difficulty: Medium
// Question number: 91
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Asagidan yukariya (bottom-up) dinamik programlama, tek boyutlu dizi
// Zaman Karmasikligi: O(n) - dizge bir kez taranir
// Alan Karmasikligi: O(n) - dp dizisi icin (O(1)'e de indirilebilir)
// Aciklama: dp[indeks], dizgenin ilk indeks karakterinin kac farkli sekilde
// cozulebilecegini tutar. Her adimda son bir karakter tek basina gecerliyse
// ve son iki karakter birlikte 10-26 arasindaysa iki farkli katkiyi topluyoruz.
public class Solution
{
    public int NumDecodings(string dizge)
    {
        int uzunluk = dizge.Length;

        if (uzunluk == 0 || dizge[0] == '0')
        {
            return 0;
        }

        int[] dp = new int[uzunluk + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int indeks = 2; indeks <= uzunluk; indeks++)
        {
            char sonKarakter = dizge[indeks - 1];
            char oncekiKarakter = dizge[indeks - 2];

            if (sonKarakter != '0')
            {
                dp[indeks] += dp[indeks - 1];
            }

            int ikiliDeger = (oncekiKarakter - '0') * 10 + (sonKarakter - '0');
            if (ikiliDeger >= 10 && ikiliDeger <= 26)
            {
                dp[indeks] += dp[indeks - 2];
            }
        }

        return dp[uzunluk];
    }
}
