// 50 - Pow(x, n) - Medium
// Task: Compute x raised to the power n efficiently, including negative exponents.
// Official link: https://leetcode.com/problems/powx-n/
// Difficulty: Medium
// Question number: 50
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Hizli Kuvvet Alma - Ozyinelemeli (Recursive Fast Power)
// Us'u ikiye bolerek problemi kucultur: x^n = (x^(n/2))^2, tek sayi
// oldugunda bir fazladan x carpilir. Negatif us icin 1/x kullanilir.
// Zaman Karmasikligi: O(log|n|)
// Alan Karmasikligi: O(log|n|) (ozyineleme yigini nedeniyle)

public class Solution
{
    public double MyPow(double x, int n)
    {
        long uzunUs = n;

        if (uzunUs < 0)
        {
            return 1.0 / HizliKuvvet(x, -uzunUs);
        }

        return HizliKuvvet(x, uzunUs);
    }

    private double HizliKuvvet(double taban, long us)
    {
        if (us == 0)
        {
            return 1.0;
        }

        double yariSonuc = HizliKuvvet(taban, us / 2);

        double tamSonuc = yariSonuc * yariSonuc;

        if (us % 2 == 1)
        {
            tamSonuc *= taban;
        }

        return tamSonuc;
    }
}
