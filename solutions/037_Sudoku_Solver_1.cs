// 37 - Sudoku Solver - Hard
// Task: Fill a Sudoku board so every row, column, and box satisfies Sudoku rules.
// Official link: https://leetcode.com/problems/sudoku-solver/
// Difficulty: Hard
// Question number: 37
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: Basit Backtracking
// Bos hucreleri sirayla gezip her birine 1-9 arasi rakamlari deniyoruz.
// Bir rakam gecerliyse yerlestirip devam ediyoruz, cikmaza girersek geri aliyoruz (backtrack).
// Zaman Karmasikligi: O(9^(bos hucre sayisi)) en kotu durumda
// Alan Karmasikligi: O(1) ekstra alan (tahta uzerinde calisiyor, recursion stack haric)

public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        CozBacktrack(board);
    }

    private bool CozBacktrack(char[][] tahta)
    {
        for (int satir = 0; satir < 9; satir++)
        {
            for (int sutun = 0; sutun < 9; sutun++)
            {
                if (tahta[satir][sutun] == '.')
                {
                    for (char rakam = '1'; rakam <= '9'; rakam++)
                    {
                        if (YerlestirmeGecerliMi(tahta, satir, sutun, rakam))
                        {
                            tahta[satir][sutun] = rakam;

                            if (CozBacktrack(tahta))
                            {
                                return true;
                            }

                            // Cikmaza girdik, geri al
                            tahta[satir][sutun] = '.';
                        }
                    }

                    // Bu hucre icin hicbir rakam calismadi
                    return false;
                }
            }
        }

        // Bos hucre kalmadi, tahta tamamlandi
        return true;
    }

    private bool YerlestirmeGecerliMi(char[][] tahta, int satir, int sutun, char rakam)
    {
        for (int i = 0; i < 9; i++)
        {
            if (tahta[satir][i] == rakam)
            {
                return false;
            }

            if (tahta[i][sutun] == rakam)
            {
                return false;
            }

            int kutuSatir = 3 * (satir / 3) + i / 3;
            int kutuSutun = 3 * (sutun / 3) + i % 3;

            if (tahta[kutuSatir][kutuSutun] == rakam)
            {
                return false;
            }
        }

        return true;
    }
}
