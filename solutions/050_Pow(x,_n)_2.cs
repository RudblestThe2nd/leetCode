// 50 - Pow(x, n) - Medium
// Task: Compute x raised to the power n efficiently, including negative exponents.
// Official link: https://leetcode.com/problems/powx-n/
// Difficulty: Medium
// Question number: 50
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Hizli Kuvvet Alma - Iteratif Bit Manipulasyonu (Binary Exponentiation)
// Us'un ikili (binary) gosterimindeki her bit icin tabani karesini
// alarak ilerletiriz; bit 1 oldugunda o anki tabani sonuca katariz.
// Ozyineleme kullanmadan sabit ek yigin alaniyla calisir.
// Zaman Karmasikligi: O(log|n|)
// Alan Karmasikligi: O(1)

public class Solution
{
    public double MyPow(double x, int n)
    {
        long uzunUs = n;

        double taban = x;

        if (uzunUs < 0)
        {
            taban = 1.0 / x;
            uzunUs = -uzunUs;
        }

        double sonuc = 1.0;

        while (uzunUs > 0)
        {
            if ((uzunUs & 1) == 1)
            {
                sonuc *= taban;
            }

            taban *= taban;

            uzunUs >>= 1;
        }

        return sonuc;
    }
}
