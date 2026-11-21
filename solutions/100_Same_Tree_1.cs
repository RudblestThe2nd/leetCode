// 100 - Same Tree - Easy
// Task: Determine whether two binary trees have identical structure and node values.
// Official link: https://leetcode.com/problems/same-tree/
// Difficulty: Easy
// Question number: 100
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) esli karsilastirma.
// Iki agac ayni anda gezilir; her adimda dugumlerin null durumu ve degeri karsilastirilir.
// Zaman Karmasikligi: O(n) - kucuk agacin dugum sayisi kadar karsilastirma yapilir.
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }

        if (p.deger != q.deger)
        {
            return false;
        }

        bool solAyni = IsSameTree(p.sol, q.sol);
        bool sagAyni = IsSameTree(p.sag, q.sag);

        return solAyni && sagAyni;
    }
}
