// 69 - Sqrt(x) - Easy
// Task: Return the integer square root of a non-negative number, rounded down.
// Official link: https://leetcode.com/problems/sqrtx/
// Difficulty: Easy
// Question number: 69
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Newton'un metodu (Newton's method) ile yakinsama
// Zaman Karmasikligi: O(log x) - hizli yakinsama sayesinde
// Alan Karmasikligi: O(1)
// Aciklama: Tahmin degeri her adimda (tahmin + x / tahmin) / 2 formuluyle
// guncellenerek gercek kareokun degerine yakinsanir. Tahminin karesi x'i
// asmayacak sekilde durdurulur ve tam sayi kismi sonuc olarak dondurulur.

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        long tahmin = x;

        while (tahmin * tahmin > x)
        {
            tahmin = (tahmin + x / tahmin) / 2;
        }

        return (int)tahmin;
    }
}
