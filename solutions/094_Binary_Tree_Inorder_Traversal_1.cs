// 94 - Binary Tree Inorder Traversal - Easy
// Task: Return the inorder traversal of a binary tree.
// Official link: https://leetcode.com/problems/binary-tree-inorder-traversal/
// Difficulty: Easy
// Question number: 94
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) inorder gezinme.
// Once sol alt agac, sonra kok, sonra sag alt agac ziyaret edilir.
// Zaman Karmasikligi: O(n) - her dugum bir kez ziyaret edilir.
// Alan Karmasikligi: O(n) - cagri yiginin derinligi ve sonuc listesi icin (en kotu durumda dogrusal agac).

using System.Collections.Generic;

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
    public IList<int> InorderTraversal(TreeNode kok)
    {
        var sonuc = new List<int>();

        Gez(kok, sonuc);

        return sonuc;
    }

    private void Gez(TreeNode dugum, List<int> sonuc)
    {
        if (dugum == null)
        {
            return;
        }

        Gez(dugum.sol, sonuc);

        sonuc.Add(dugum.deger);

        Gez(dugum.sag, sonuc);
    }
}
