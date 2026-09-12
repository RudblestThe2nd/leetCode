// 37 - Sudoku Solver - Hard
// Task: Fill a Sudoku board so every row, column, and box satisfies Sudoku rules.
// Official link: https://leetcode.com/problems/sudoku-solver/
// Difficulty: Hard
// Question number: 37
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Backtracking + Constraint Propagation (bitmask ile hizli kontrol)
// Her satir, sutun ve kutu icin kullanilan rakamlari bitmask olarak onceden hesapliyoruz.
// Bir rakamin yerlestirilebilir olup olmadigini O(1) bit kontroluyle anliyoruz,
// boylece her denemede tahtayi bastan taramaya gerek kalmiyor.
// Zaman Karmasikligi: O(9^(bos hucre sayisi)) en kotu durumda, ama sabit carpanlar cok daha kucuk
// Alan Karmasikligi: O(1) (27 adet sabit boyutlu bitmask)

public class Solution
{
    private int[] satirMaskeleri;
    private int[] sutunMaskeleri;
    private int[] kutuMaskeleri;

    public void SolveSudoku(char[][] board)
    {
        satirMaskeleri = new int[9];
        sutunMaskeleri = new int[9];
        kutuMaskeleri = new int[9];

        for (int satir = 0; satir < 9; satir++)
        {
            for (int sutun = 0; sutun < 9; sutun++)
            {
                char karakter = board[satir][sutun];

                if (karakter != '.')
                {
                    int bit = 1 << (karakter - '1');
                    int kutuIndeksi = (satir / 3) * 3 + (sutun / 3);

                    satirMaskeleri[satir] |= bit;
                    sutunMaskeleri[sutun] |= bit;
                    kutuMaskeleri[kutuIndeksi] |= bit;
                }
            }
        }

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
                    int kutuIndeksi = (satir / 3) * 3 + (sutun / 3);

                    for (int rakam = 1; rakam <= 9; rakam++)
                    {
                        int bit = 1 << (rakam - 1);
                        bool kullanimda = (satirMaskeleri[satir] & bit) != 0 ||
                                           (sutunMaskeleri[sutun] & bit) != 0 ||
                                           (kutuMaskeleri[kutuIndeksi] & bit) != 0;

                        if (!kullanimda)
                        {
                            // Rakami yerlestir ve maskeleri guncelle
                            tahta[satir][sutun] = (char)('0' + rakam);
                            satirMaskeleri[satir] |= bit;
                            sutunMaskeleri[sutun] |= bit;
                            kutuMaskeleri[kutuIndeksi] |= bit;

                            if (CozBacktrack(tahta))
                            {
                                return true;
                            }

                            // Cikmaza girdik, geri al
                            tahta[satir][sutun] = '.';
                            satirMaskeleri[satir] &= ~bit;
                            sutunMaskeleri[sutun] &= ~bit;
                            kutuMaskeleri[kutuIndeksi] &= ~bit;
                        }
                    }

                    return false;
                }
            }
        }

        return true;
    }
}
