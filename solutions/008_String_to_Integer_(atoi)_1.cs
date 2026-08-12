// 8 - String to Integer (atoi) - Medium
// Task: Parse a string into a 32-bit signed integer following common atoi-style rules for spaces, signs, and invalid characters.
// Official link: https://leetcode.com/problems/string-to-integer-atoi/
// Difficulty: Medium
// Question number: 8
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Manuel Karakter Tarama - bosluklari atla, isareti oku, basamaklari long ile biriktirip sinirla.
// Zaman Karmasikligi: O(n) - dizedeki her karakter en fazla bir kez okunur.
// Alan Karmasikligi: O(1) - sabit ek alan.

public class Solution
{
    public int MyAtoi(string s)
    {
        int indeks = 0;
        int uzunluk = s.Length;

        while (indeks < uzunluk && s[indeks] == ' ')
        {
            indeks++;
        }

        int isaret = 1;
        if (indeks < uzunluk && (s[indeks] == '+' || s[indeks] == '-'))
        {
            if (s[indeks] == '-')
            {
                isaret = -1;
            }
            indeks++;
        }

        long sonuc = 0;

        while (indeks < uzunluk && s[indeks] >= '0' && s[indeks] <= '9')
        {
            int basamak = s[indeks] - '0';
            sonuc = sonuc * 10 + basamak;

            if (isaret == 1 && sonuc > int.MaxValue)
            {
                return int.MaxValue;
            }

            if (isaret == -1 && -sonuc < int.MinValue)
            {
                return int.MinValue;
            }

            indeks++;
        }

        return (int)(sonuc * isaret);
    }
}
