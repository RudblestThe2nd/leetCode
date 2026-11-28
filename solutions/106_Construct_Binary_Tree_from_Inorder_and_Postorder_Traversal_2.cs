// 106 - Construct Binary Tree from Inorder and Postorder Traversal - Medium
// Task: Build a binary tree from its inorder and postorder traversal arrays.
// Official link: https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
// Difficulty: Medium
// Question number: 106
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

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

// Yaklasim 2: Iteratif - Yigin (stack) kullanarak insa
// Postorder dizisini sondan basa gezip, her yeni dugumu yigindaki en son
// dugumun sol veya sag cocugu olarak baglayip yigina ekliyoruz.
// Inorder dizisini sondan basa kontrol ederek eslesmede yigindan cikariyoruz.
// Zaman Karmasikligi: O(n) - her dugum bir kez islenir
// Alan Karmasikligi: O(n) - yigin icin

public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (postorder.Length == 0)
        {
            return null;
        }

        int sonIndeks = postorder.Length - 1;

        TreeNode kok = new TreeNode(postorder[sonIndeks]);

        Stack<TreeNode> yigin = new Stack<TreeNode>();
        yigin.Push(kok);

        int inorderIndeksi = inorder.Length - 1;

        for (int i = sonIndeks - 1; i >= 0; i--)
        {
            TreeNode yeniDugum = new TreeNode(postorder[i]);
            TreeNode ustDugum = yigin.Peek();

            if (ustDugum.deger != inorder[inorderIndeksi])
            {
                ustDugum.sag = yeniDugum;
            }
            else
            {
                while (yigin.Count > 0 && yigin.Peek().deger == inorder[inorderIndeksi])
                {
                    ustDugum = yigin.Pop();
                    inorderIndeksi--;
                }

                ustDugum.sol = yeniDugum;
            }

            yigin.Push(yeniDugum);
        }

        return kok;
    }
}
