// 94 - Binary Tree Inorder Traversal - Easy
// Task: Return the inorder traversal of a binary tree.
// Official link: https://leetcode.com/problems/binary-tree-inorder-traversal/
// Difficulty: Easy
// Question number: 94
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) inorder gezinme, kendi yigin (stack) yapimizla.
// Once sol tarafa gidebildigimiz kadar giderek yigina eklenir, sonra geri cikilip deger okunur ve sag tarafa gecilir.
// Zaman Karmasikligi: O(n) - her dugum bir kez yigina eklenip bir kez cikarilir.
// Alan Karmasikligi: O(n) - yigin en kotu durumda tum dugumleri tutabilir (dogrusal agac).

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
        var yigin = new Stack<TreeNode>();
        var simdiki = kok;

        while (simdiki != null || yigin.Count > 0)
        {
            while (simdiki != null)
            {
                yigin.Push(simdiki);
                simdiki = simdiki.sol;
            }

            simdiki = yigin.Pop();

            sonuc.Add(simdiki.deger);

            simdiki = simdiki.sag;
        }

        return sonuc;
    }
}
