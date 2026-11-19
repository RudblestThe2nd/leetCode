// 98 - Validate Binary Search Tree - Medium
// Task: Check whether a binary tree satisfies the binary search tree ordering rules.
// Official link: https://leetcode.com/problems/validate-binary-search-tree/
// Difficulty: Medium
// Question number: 98
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) alt-ust sinir (min/max) kontrolu.
// Her dugum icin gecerli bir deger araligi asagi dogru tasinir ve dugum bu aralikta olmali.
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
    public bool IsValidBST(TreeNode kok)
    {
        return Kontrol(kok, long.MinValue, long.MaxValue);
    }

    private bool Kontrol(TreeNode dugum, long altSinir, long ustSinir)
    {
        if (dugum == null)
        {
            return true;
        }

        if (dugum.deger <= altSinir || dugum.deger >= ustSinir)
        {
            return false;
        }

        bool solGecerli = Kontrol(dugum.sol, altSinir, dugum.deger);
        bool sagGecerli = Kontrol(dugum.sag, dugum.deger, ustSinir);

        return solGecerli && sagGecerli;
    }
}
