// 89 - Gray Code - Medium
// Task: Generate a Gray code sequence of length 2 to the power n.
// Official link: https://leetcode.com/problems/gray-code/
// Difficulty: Medium
// Question number: 89
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Matematiksel formul, i xor (i >> 1)
// Zaman Karmasikligi: O(2^n) - toplam 2^n eleman uretilir
// Alan Karmasikligi: O(2^n) - sonuc listesi icin
// Aciklama: Bilinen bir ozellik sayesinde, i sayisinin kendisiyle bir bit
// saga kaydirilmis halinin xor'u dogrudan Gray kodunu verir. Bu formulu
// 0'dan 2^n - 1'e kadar her sayi icin uyguluyoruz.
public class Solution
{
    public System.Collections.Generic.IList<int> GrayCode(int n)
    {
        var sonuc = new System.Collections.Generic.List<int>();
        int toplamSayi = 1 << n;

        for (int sayi = 0; sayi < toplamSayi; sayi++)
        {
            int grayDegeri = sayi ^ (sayi >> 1);
            sonuc.Add(grayDegeri);
        }

        return sonuc;
    }
}
