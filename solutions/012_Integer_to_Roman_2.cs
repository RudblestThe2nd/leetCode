// 12 - Integer to Roman - Medium
// Task: Convert an integer into its Roman numeral representation.
// Official link: https://leetcode.com/problems/integer-to-roman/
// Difficulty: Medium
// Question number: 12
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Basamak Bazli Sabit Tablo - sayiyi binler, yuzler, onlar ve birler basamagina ayirip her biri icin ayri sabit tablodan sembol al.
// Zaman Karmasikligi: O(1) - her basamak icin sabit sayida islem, toplamda sabit ust sinir.
// Alan Karmasikligi: O(1) - sabit boyutlu diziler kullanilir.

public class Solution
{
    private static readonly string[] binlerBasamagi = { "", "M", "MM", "MMM" };
    private static readonly string[] yuzlerBasamagi = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    private static readonly string[] onlarBasamagi = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    private static readonly string[] birlerBasamagi = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    public string IntToRoman(int num)
    {
        int binlerHanesi = num / 1000;
        int yuzlerHanesi = (num % 1000) / 100;
        int onlarHanesi = (num % 100) / 10;
        int birlerHanesi = num % 10;

        return binlerBasamagi[binlerHanesi] +
               yuzlerBasamagi[yuzlerHanesi] +
               onlarBasamagi[onlarHanesi] +
               birlerBasamagi[birlerHanesi];
    }
}
