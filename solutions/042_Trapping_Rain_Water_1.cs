// 42 - Trapping Rain Water - Hard
// Task: Given bar heights, compute how much rainwater can be trapped between them.
// Official link: https://leetcode.com/problems/trapping-rain-water/
// Difficulty: Hard
// Question number: 42
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Two-Pointer (iki isaretci) yaklasimi
// Sol ve sagdan iki isaretci ile ilerleyip, hangi tarafin maksimum yuksekligi
// daha kucukse o taraftaki suyu hesaplayip isaretciyi ilerletiyoruz. Ekstra
// dizi kullanmadan tek gecisle sonucu buluyoruz.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(1)

public class Solution
{
    public int Trap(int[] height)
    {
        int sol = 0;
        int sag = height.Length - 1;
        int solMaksimum = 0;
        int sagMaksimum = 0;
        int toplamSu = 0;

        while (sol < sag)
        {
            if (height[sol] <= height[sag])
            {
                if (height[sol] >= solMaksimum)
                {
                    solMaksimum = height[sol];
                }
                else
                {
                    toplamSu += solMaksimum - height[sol];
                }

                sol++;
            }
            else
            {
                if (height[sag] >= sagMaksimum)
                {
                    sagMaksimum = height[sag];
                }
                else
                {
                    toplamSu += sagMaksimum - height[sag];
                }

                sag--;
            }
        }

        return toplamSu;
    }
}
