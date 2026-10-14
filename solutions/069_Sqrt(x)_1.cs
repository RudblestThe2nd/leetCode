// 69 - Sqrt(x) - Easy
// Task: Return the integer square root of a non-negative number, rounded down.
// Official link: https://leetcode.com/problems/sqrtx/
// Difficulty: Easy
// Question number: 69
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ikili arama (binary search)
// Zaman Karmasikligi: O(log x)
// Alan Karmasikligi: O(1)
// Aciklama: 0 ile x arasinda ikili arama yapilir. Ortadaki degerin karesi x'e
// esit veya kucukse bu deger aday olarak saklanir ve arama sagda devam eder,
// buyukse arama solda devam eder.

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        long sol = 1;
        long sag = x;
        long enIyiAday = 1;

        while (sol <= sag)
        {
            long orta = sol + (sag - sol) / 2;
            long ortaninKaresi = orta * orta;

            if (ortaninKaresi == x)
            {
                return (int)orta;
            }
            else if (ortaninKaresi < x)
            {
                enIyiAday = orta;
                sol = orta + 1;
            }
            else
            {
                sag = orta - 1;
            }
        }

        return (int)enIyiAday;
    }
}
