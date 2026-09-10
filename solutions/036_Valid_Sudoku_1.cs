// 36 - Valid Sudoku - Medium
// Task: Validate whether a partially filled Sudoku board obeys row, column, and box rules.
// Official link: https://leetcode.com/problems/valid-sudoku/
// Difficulty: Medium
// Question number: 36
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 1: HashSet kullanarak satir/sutun/kutu kontrolunu tek gecisle yapma
// Tahtayi tek bir dongude gezerek her hucre icin satir, sutun ve 3x3 kutu
// bilgisini benzersiz anahtarlarla HashSet'lere ekliyoruz. Ayni anahtar tekrar
// eklenmeye calisilirsa gecersiz sudoku demektir.
// Zaman Karmasikligi: O(1) (9x9 sabit boyut, pratikte O(n^2))
// Alan Karmasikligi: O(1) (sabit boyutlu hashset'ler)

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> gorulenler = new HashSet<string>();

        for (int satir = 0; satir < 9; satir++)
        {
            for (int sutun = 0; sutun < 9; sutun++)
            {
                char karakter = board[satir][sutun];

                if (karakter == '.')
                {
                    continue;
                }

                int kutuNo = (satir / 3) * 3 + (sutun / 3);

                string satirAnahtari = "satir" + satir + "-" + karakter;
                string sutunAnahtari = "sutun" + sutun + "-" + karakter;
                string kutuAnahtari = "kutu" + kutuNo + "-" + karakter;

                if (!gorulenler.Add(satirAnahtari) ||
                    !gorulenler.Add(sutunAnahtari) ||
                    !gorulenler.Add(kutuAnahtari))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
