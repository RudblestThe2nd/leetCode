// 105 - Construct Binary Tree from Preorder and Inorder Traversal - Medium
// Task: Build a binary tree from its preorder and inorder traversal arrays.
// Official link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
// Difficulty: Medium
// Question number: 105
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
// Preorder dizisini sirayla gezip, her yeni dugumu yigindaki en son
// dugumun sag veya sol cocugu olarak baglayip yigina ekliyoruz.
// Inorder dizisindeki eslesme bulundugunda yigindan cikartip devam ediyoruz.
// Zaman Karmasikligi: O(n) - her dugum bir kez islenir
// Alan Karmasikligi: O(n) - yigin icin

public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0)
        {
            return null;
        }

        TreeNode kok = new TreeNode(preorder[0]);

        Stack<TreeNode> yigin = new Stack<TreeNode>();
        yigin.Push(kok);

        int inorderIndeksi = 0;

        for (int i = 1; i < preorder.Length; i++)
        {
            TreeNode yeniDugum = new TreeNode(preorder[i]);
            TreeNode ustDugum = yigin.Peek();

            if (ustDugum.deger != inorder[inorderIndeksi])
            {
                ustDugum.sol = yeniDugum;
            }
            else
            {
                while (yigin.Count > 0 && yigin.Peek().deger == inorder[inorderIndeksi])
                {
                    ustDugum = yigin.Pop();
                    inorderIndeksi++;
                }

                ustDugum.sag = yeniDugum;
            }

            yigin.Push(yeniDugum);
        }

        return kok;
    }
}
