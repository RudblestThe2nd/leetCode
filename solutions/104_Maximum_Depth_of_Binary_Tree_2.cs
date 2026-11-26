// 104 - Maximum Depth of Binary Tree - Easy
// Task: Return the maximum depth of a binary tree.
// Official link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
// Difficulty: Easy
// Question number: 104
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

// Yaklasim 2: Iteratif BFS (kuyruk ile seviye sayma)
// Kuyruk yardimiyla seviye seviye ilerleyip, her tam seviye tamamlaninca
// derinlik sayacini bir arttiriyoruz.
// Zaman Karmasikligi: O(n) - her dugume bir kez ugranir
// Alan Karmasikligi: O(n) - en genis seviyedeki dugumler icin kuyruk

public class Solution
{
    public int MaxDepth(TreeNode kok)
    {
        if (kok == null)
        {
            return 0;
        }

        Queue<TreeNode> kuyruk = new Queue<TreeNode>();
        kuyruk.Enqueue(kok);

        int derinlik = 0;

        while (kuyruk.Count > 0)
        {
            int seviyeBoyutu = kuyruk.Count;

            for (int i = 0; i < seviyeBoyutu; i++)
            {
                TreeNode dugum = kuyruk.Dequeue();

                if (dugum.sol != null)
                {
                    kuyruk.Enqueue(dugum.sol);
                }

                if (dugum.sag != null)
                {
                    kuyruk.Enqueue(dugum.sag);
                }
            }

            derinlik++;
        }

        return derinlik;
    }
}
