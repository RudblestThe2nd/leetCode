// 48 - Rotate Image - Medium
// Task: Rotate an n by n matrix 90 degrees clockwise in place.
// Official link: https://leetcode.com/problems/rotate-image/
// Difficulty: Medium
// Question number: 48
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Transpoz + Yatay Ayna (Transpose then Reverse Rows)
// Once matrisin transpozunu aliriz (satir ve sutunlari degistiririz),
// sonra her satiri kendi icinde ters cevirilir. Bu iki islemin bilesimi
// 90 derece saat yonunde donduurme islemine denktir.
// Zaman Karmasikligi: O(boyut^2)
// Alan Karmasikligi: O(1)

public class Solution
{
    public void Rotate(int[][] matris)
    {
        int boyut = matris.Length;

        for (int satir = 0; satir < boyut; satir++)
        {
            for (int sutun = satir + 1; sutun < boyut; sutun++)
            {
                int gecici = matris[satir][sutun];
                matris[satir][sutun] = matris[sutun][satir];
                matris[sutun][satir] = gecici;
            }
        }

        for (int satir = 0; satir < boyut; satir++)
        {
            int sol = 0;
            int sag = boyut - 1;

            while (sol < sag)
            {
                int gecici = matris[satir][sol];
                matris[satir][sol] = matris[satir][sag];
                matris[satir][sag] = gecici;

                sol++;
                sag--;
            }
        }
    }
}
