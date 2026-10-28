// 75 - Sort Colors - Medium
// Task: Sort an array containing only 0, 1, and 2 in place.
// Official link: https://leetcode.com/problems/sort-colors/
// Difficulty: Medium
// Question number: 75
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Hollanda bayragi (Dutch national flag) algoritmasi. Uc isaretci
// (dusukIsaretci, mevcutIsaretci, yuksekIsaretci) kullanarak diziyi tek gecisde,
// ekstra sayma yapmadan yerinde siraliyoruz.
// Zaman Karmasikligi: O(uzunluk)
// Alan Karmasikligi: O(1)

public class Solution
{
    public void SortColors(int[] dizi)
    {
        int dusukIsaretci = 0;
        int mevcutIsaretci = 0;
        int yuksekIsaretci = dizi.Length - 1;

        while (mevcutIsaretci <= yuksekIsaretci)
        {
            if (dizi[mevcutIsaretci] == 0)
            {
                int gecici = dizi[dusukIsaretci];
                dizi[dusukIsaretci] = dizi[mevcutIsaretci];
                dizi[mevcutIsaretci] = gecici;

                dusukIsaretci++;
                mevcutIsaretci++;
            }
            else if (dizi[mevcutIsaretci] == 2)
            {
                int gecici = dizi[yuksekIsaretci];
                dizi[yuksekIsaretci] = dizi[mevcutIsaretci];
                dizi[mevcutIsaretci] = gecici;

                yuksekIsaretci--;
            }
            else
            {
                mevcutIsaretci++;
            }
        }
    }
}
