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

// Yaklasim 1: Recursive - Inorder degerlerinin indeksini haritada tutma
// Postorder dizisinin son elemani her zaman kokdur. Inorder dizisinde
// bu kokun konumunu harita ile bulup, sag alt agaci once, sonra sol alt
// agaci insa ediyoruz (postorder sondan basa: sag, sol, kok).
// Zaman Karmasikligi: O(n) - her dugum bir kez islenir
// Alan Karmasikligi: O(n) - harita ve cagri yigini icin

public class Solution
{
    private int postorderIndeksi;
    private Dictionary<int, int> inorderHaritasi;
    private int[] postorderDizisi;

    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        postorderDizisi = postorder;
        postorderIndeksi = postorder.Length - 1;

        inorderHaritasi = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++)
        {
            inorderHaritasi[inorder[i]] = i;
        }

        return InsaEt(0, inorder.Length - 1);
    }

    private TreeNode InsaEt(int solSinir, int sagSinir)
    {
        if (solSinir > sagSinir)
        {
            return null;
        }

        int kokDegeri = postorderDizisi[postorderIndeksi];
        postorderIndeksi--;

        TreeNode kok = new TreeNode(kokDegeri);

        int kokIndeksi = inorderHaritasi[kokDegeri];

        kok.sag = InsaEt(kokIndeksi + 1, sagSinir);
        kok.sol = InsaEt(solSinir, kokIndeksi - 1);

        return kok;
    }
}
