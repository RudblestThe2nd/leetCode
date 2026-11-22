// 101 - Symmetric Tree - Easy
// Task: Determine whether a binary tree is a mirror of itself.
// Official link: https://leetcode.com/problems/symmetric-tree/
// Difficulty: Easy
// Question number: 101
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) ayna karsilastirma.
// Agacin sol alt agaci ile sag alt agaci birbirinin aynasi olacak sekilde karsilikli gezilir.
// Zaman Karmasikligi: O(n) - her dugum bir kez ziyaret edilir.
// Alan Karmasikligi: O(n) - cagri yiginin derinligi (en kotu durumda dogrusal agac).

public class TreeNode
{
    public int deger;
    public TreeNode sol;
    public TreeNode sag;

    public TreeNode(int deger = 0, TreeNode sol = null, TreeNode sag = null)
    {
        this.deger = deger;
        this.sol = sol;
        this.sag = sag;
    }
}

public class Solution
{
    public bool IsSymmetric(TreeNode kok)
    {
        if (kok == null)
        {
            return true;
        }

        return AynaKontrol(kok.sol, kok.sag);
    }

    private bool AynaKontrol(TreeNode sol, TreeNode sag)
    {
        if (sol == null && sag == null)
        {
            return true;
        }

        if (sol == null || sag == null)
        {
            return false;
        }

        if (sol.deger != sag.deger)
        {
            return false;
        }

        bool disKontrol = AynaKontrol(sol.sol, sag.sag);
        bool icKontrol = AynaKontrol(sol.sag, sag.sol);

        return disKontrol && icKontrol;
    }
}
