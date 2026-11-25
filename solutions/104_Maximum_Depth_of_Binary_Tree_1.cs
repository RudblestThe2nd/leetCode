// 104 - Maximum Depth of Binary Tree - Easy
// Task: Return the maximum depth of a binary tree.
// Official link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
// Difficulty: Easy
// Question number: 104
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

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

// Yaklasim 1: Recursive DFS
// Her dugum icin sol ve sag alt agacin derinligini hesaplayip
// buyuk olanina bir ekleyerek yukari dogru donduruyoruz.
// Zaman Karmasikligi: O(n) - her dugume bir kez ugranir
// Alan Karmasikligi: O(h) - h agac yuksekligi, cagri yigini icin

public class Solution
{
    public int MaxDepth(TreeNode kok)
    {
        if (kok == null)
        {
            return 0;
        }

        int solDerinlik = MaxDepth(kok.sol);
        int sagDerinlik = MaxDepth(kok.sag);

        int buyukOlan = solDerinlik > sagDerinlik ? solDerinlik : sagDerinlik;

        return buyukOlan + 1;
    }
}
