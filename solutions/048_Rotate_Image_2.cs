// 48 - Rotate Image - Medium
// Task: Rotate an n by n matrix 90 degrees clockwise in place.
// Official link: https://leetcode.com/problems/rotate-image/
// Difficulty: Medium
// Question number: 48
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Katman Katman Dort Yonlu Dongusel Takas (Layer by Layer Rotation)
// Matrisi ic ice kareler (katmanlar) olarak dusunuruz. Her katmanda,
// ust kenardaki bir eleman ile sag, alt ve sol kenardaki karsilik gelen
// elemanlari dort'lu gruplar halinde dongusel olarak takas ederiz.
// Zaman Karmasikligi: O(boyut^2)
// Alan Karmasikligi: O(1)

public class Solution
{
    public void Rotate(int[][] matris)
    {
        int boyut = matris.Length;

        for (int katman = 0; katman < boyut / 2; katman++)
        {
            int ilkIndeks = katman;
            int sonIndeks = boyut - 1 - katman;

            for (int ofset = ilkIndeks; ofset < sonIndeks; ofset++)
            {
                int gecici = matris[ilkIndeks][ofset];

                matris[ilkIndeks][ofset] = matris[boyut - 1 - ofset][ilkIndeks];

                matris[boyut - 1 - ofset][ilkIndeks] = matris[sonIndeks][boyut - 1 - ofset];

                matris[sonIndeks][boyut - 1 - ofset] = matris[ofset][sonIndeks];

                matris[ofset][sonIndeks] = gecici;
            }
        }
    }
}
