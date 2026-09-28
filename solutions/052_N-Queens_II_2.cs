// 52 - N-Queens II - Hard
// Task: Return the number of valid n-queens board arrangements.
// Official link: https://leetcode.com/problems/n-queens-ii/
// Difficulty: Hard
// Question number: 52
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Bit Manipulasyonu ile Backtracking (Bitmask Based)
// Kullanilan sutunlari ve capraz yonleri tamsayi bitmaskeleri olarak
// tutariz. Her satirda musait konumlari bitwise AND/NOT ile buluruz
// ve en dustuk bitten baslayarak sirayla deneriz. HashSet'ten daha
// hizli calisir cunku islemler dogrudan CPU seviyesinde yapilir.
// Zaman Karmasikligi: O(n!) (en kotu durum, budama ile pratikte daha az)
// Alan Karmasikligi: O(n) (cagri yigini icin)

public class Solution
{
    private int boyut;

    public int TotalNQueens(int n)
    {
        boyut = n;

        return GeriDon(0, 0, 0, 0);
    }

    private int GeriDon(int satir, int kullanilanSutunMaskesi, int kullanilanSolCaprazMaskesi, int kullanilanSagCaprazMaskesi)
    {
        if (satir == boyut)
        {
            return 1;
        }

        int tamDolu = (1 << boyut) - 1;

        int dolMaske = kullanilanSutunMaskesi | kullanilanSolCaprazMaskesi | kullanilanSagCaprazMaskesi;

        int musaitKonumlar = tamDolu & ~dolMaske;

        int gecerliSayim = 0;

        while (musaitKonumlar != 0)
        {
            int secilenBit = musaitKonumlar & (-musaitKonumlar);

            musaitKonumlar -= secilenBit;

            gecerliSayim += GeriDon(
                satir + 1,
                kullanilanSutunMaskesi | secilenBit,
                (kullanilanSolCaprazMaskesi | secilenBit) << 1,
                (kullanilanSagCaprazMaskesi | secilenBit) >> 1);
        }

        return gecerliSayim;
    }
}
