// 102 - Binary Tree Level Order Traversal - Medium
// Task: Return the level-order traversal of a binary tree from top to bottom.
// Official link: https://leetcode.com/problems/binary-tree-level-order-traversal/
// Difficulty: Medium
// Question number: 102
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) DFS, dugumun derinligine gore dogru sonuc listesine ekleme.
// Her dugum ziyaret edilirken derinlik indeksi kullanilarak ilgili seviye listesine deger eklenir.
// Zaman Karmasikligi: O(n) - her dugum bir kez ziyaret edilir.
// Alan Karmasikligi: O(n) - sonuc listesi ve cagri yiginin derinligi icin.

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
    public IList<IList<int>> LevelOrder(TreeNode kok)
    {
        var sonuc = new List<IList<int>>();

        Gez(kok, 0, sonuc);

        return sonuc;
    }

    private void Gez(TreeNode dugum, int derinlik, List<IList<int>> sonuc)
    {
        if (dugum == null)
        {
            return;
        }

        if (sonuc.Count == derinlik)
        {
            sonuc.Add(new List<int>());
        }

        sonuc[derinlik].Add(dugum.deger);

        Gez(dugum.sol, derinlik + 1, sonuc);

        Gez(dugum.sag, derinlik + 1, sonuc);
    }
}
