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

// Yaklasim 1: Recursive - Inorder degerlerinin indeksini haritada tutma
// Preorder dizisindeki ilk eleman her zaman kokdur. Inorder dizisinde
// bu kokun konumunu bir harita ile hizlica bulup, sol ve sag alt agac
// araliklarini belirleyip recursive olarak insa ediyoruz.
// Zaman Karmasikligi: O(n) - her dugum bir kez islenir
// Alan Karmasikligi: O(n) - harita ve cagri yigini icin

public class Solution
{
    private int preorderIndeksi;
    private Dictionary<int, int> inorderHaritasi;
    private int[] preorderDizisi;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        preorderDizisi = preorder;
        preorderIndeksi = 0;

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

        int kokDegeri = preorderDizisi[preorderIndeksi];
        preorderIndeksi++;

        TreeNode kok = new TreeNode(kokDegeri);

        int kokIndeksi = inorderHaritasi[kokDegeri];

        kok.sol = InsaEt(solSinir, kokIndeksi - 1);
        kok.sag = InsaEt(kokIndeksi + 1, sagSinir);

        return kok;
    }
}
