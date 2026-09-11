// 36 - Valid Sudoku - Medium
// Task: Validate whether a partially filled Sudoku board obeys row, column, and box rules.
// Official link: https://leetcode.com/problems/valid-sudoku/
// Difficulty: Medium
// Question number: 36
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Her satir/sutun/3x3 kutu icin ayri dogrulama fonksiyonu cagirma
// Daha fazla gecis yapiyoruz ama kod daha okunakli ve sorumluluklar ayrilmis oluyor.
// Once tum satirlari, sonra tum sutunlari, sonra tum kutulari tek tek kontrol ediyoruz.
// Zaman Karmasikligi: O(1) (9x9 sabit boyut, pratikte O(n^2))
// Alan Karmasikligi: O(1) (sabit boyutlu yardimci diziler)

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int satir = 0; satir < 9; satir++)
        {
            if (!SatirGecerliMi(board, satir))
            {
                return false;
            }
        }

        for (int sutun = 0; sutun < 9; sutun++)
        {
            if (!SutunGecerliMi(board, sutun))
            {
                return false;
            }
        }

        for (int kutuSatir = 0; kutuSatir < 3; kutuSatir++)
        {
            for (int kutuSutun = 0; kutuSutun < 3; kutuSutun++)
            {
                if (!KutuGecerliMi(board, kutuSatir * 3, kutuSutun * 3))
                {
                    return false;
                }
            }
        }

        return true;
    }

    private bool SatirGecerliMi(char[][] tahta, int satirIndeksi)
    {
        bool[] gorulenRakamlar = new bool[9];

        for (int sutun = 0; sutun < 9; sutun++)
        {
            char karakter = tahta[satirIndeksi][sutun];

            if (karakter == '.')
            {
                continue;
            }

            int rakam = karakter - '1';

            if (gorulenRakamlar[rakam])
            {
                return false;
            }

            gorulenRakamlar[rakam] = true;
        }

        return true;
    }

    private bool SutunGecerliMi(char[][] tahta, int sutunIndeksi)
    {
        bool[] gorulenRakamlar = new bool[9];

        for (int satir = 0; satir < 9; satir++)
        {
            char karakter = tahta[satir][sutunIndeksi];

            if (karakter == '.')
            {
                continue;
            }

            int rakam = karakter - '1';

            if (gorulenRakamlar[rakam])
            {
                return false;
            }

            gorulenRakamlar[rakam] = true;
        }

        return true;
    }

    private bool KutuGecerliMi(char[][] tahta, int baslangicSatir, int baslangicSutun)
    {
        bool[] gorulenRakamlar = new bool[9];

        for (int satir = baslangicSatir; satir < baslangicSatir + 3; satir++)
        {
            for (int sutun = baslangicSutun; sutun < baslangicSutun + 3; sutun++)
            {
                char karakter = tahta[satir][sutun];

                if (karakter == '.')
                {
                    continue;
                }

                int rakam = karakter - '1';

                if (gorulenRakamlar[rakam])
                {
                    return false;
                }

                gorulenRakamlar[rakam] = true;
            }
        }

        return true;
    }
}
