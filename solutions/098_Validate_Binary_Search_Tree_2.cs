// 98 - Validate Binary Search Tree - Medium
// Task: Check whether a binary tree satisfies the binary search tree ordering rules.
// Official link: https://leetcode.com/problems/validate-binary-search-tree/
// Difficulty: Medium
// Question number: 98
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) inorder gezinme ile onceki degerle karsilastirma.
// Bir BST'nin inorder sirasi kesinlikle artan olmalidir; kendi yiginimizla bunu kontrol ederiz.
// Zaman Karmasikligi: O(n) - her dugum bir kez yigina eklenip bir kez cikarilir.
// Alan Karmasikligi: O(n) - yigin en kotu durumda tum dugumleri tutabilir.

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
    public bool IsValidBST(TreeNode kok)
    {
        var yigin = new Stack<TreeNode>();
        TreeNode simdiki = kok;
        long oncekiDeger = long.MinValue;

        while (simdiki != null || yigin.Count > 0)
        {
            while (simdiki != null)
            {
                yigin.Push(simdiki);
                simdiki = simdiki.sol;
            }

            simdiki = yigin.Pop();

            if (simdiki.deger <= oncekiDeger)
            {
                return false;
            }

            oncekiDeger = simdiki.deger;

            simdiki = simdiki.sag;
        }

        return true;
    }
}
