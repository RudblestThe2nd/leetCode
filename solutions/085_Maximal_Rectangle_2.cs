// 85 - Maximal Rectangle - Hard
// Task: Find the largest rectangle containing only 1s in a binary matrix.
// Official link: https://leetcode.com/problems/maximal-rectangle/
// Difficulty: Hard
// Question number: 85
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yigin kullanmadan dinamik programlama; her sutun icin
// yukseklik, sol sinir ve sag sinir dizilerini guncelleyerek ilerleme
// Zaman Karmasikligi: O(satir * sutun) - her satirda sabit sayida gecis
// Alan Karmasikligi: O(sutun) - yukseklik, sol ve sag dizileri icin
// Aciklama: Her sutun icin o ana kadar biriken yukseklik, o yukseklikte
// soldan ulasabilecegimiz en uzak sutun ve sagdan ulasabilecegimiz en
// uzak sutun bilgisi tutulur. Bu ucu birlestirerek alan hesaplanir.
public class Solution
{
    public int MaximalRectangle(char[][] matris)
    {
        if (matris.Length == 0 || matris[0].Length == 0)
        {
            return 0;
        }

        int satirSayisi = matris.Length;
        int sutunSayisi = matris[0].Length;

        int[] yukseklik = new int[sutunSayisi];
        int[] solSinir = new int[sutunSayisi];
        int[] sagSinir = new int[sutunSayisi];

        for (int sutun = 0; sutun < sutunSayisi; sutun++)
        {
            sagSinir[sutun] = sutunSayisi;
        }

        int enBuyukAlan = 0;

        for (int satir = 0; satir < satirSayisi; satir++)
        {
            int solSuAn = 0;
            int sagSuAn = sutunSayisi;

            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][sutun] == '1')
                {
                    yukseklik[sutun]++;
                }
                else
                {
                    yukseklik[sutun] = 0;
                }
            }

            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                if (matris[satir][sutun] == '1')
                {
                    solSinir[sutun] = System.Math.Max(solSinir[sutun], solSuAn);
                }
                else
                {
                    solSinir[sutun] = 0;
                    solSuAn = sutun + 1;
                }
            }

            for (int sutun = sutunSayisi - 1; sutun >= 0; sutun--)
            {
                if (matris[satir][sutun] == '1')
                {
                    sagSinir[sutun] = System.Math.Min(sagSinir[sutun], sagSuAn);
                }
                else
                {
                    sagSinir[sutun] = sutunSayisi;
                    sagSuAn = sutun;
                }
            }

            for (int sutun = 0; sutun < sutunSayisi; sutun++)
            {
                int genislik = sagSinir[sutun] - solSinir[sutun];
                int alan = genislik * yukseklik[sutun];

                if (alan > enBuyukAlan)
                {
                    enBuyukAlan = alan;
                }
            }
        }

        return enBuyukAlan;
    }
}
