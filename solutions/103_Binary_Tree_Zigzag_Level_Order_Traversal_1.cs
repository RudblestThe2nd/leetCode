// 103 - Binary Tree Zigzag Level Order Traversal - Medium
// Task: Return a binary tree level-order traversal that alternates direction at each level.
// Official link: https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
// Difficulty: Medium
// Question number: 103
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

// Yaklasim 1: BFS (kuyruk ile seviye seviye gezme)
// Her seviyeyi bir kuyruk yardimiyla dolasip, seviye numarasi tek ise
// listeyi ters cevirerek zigzag siralamayi elde ediyoruz.
// Zaman Karmasikligi: O(n) - her dugume bir kez ugranir
// Alan Karmasikligi: O(n) - kuyruk ve sonuc listesi icin

public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode kok)
    {
        IList<IList<int>> sonuc = new List<IList<int>>();

        if (kok == null)
        {
            return sonuc;
        }

        Queue<TreeNode> kuyruk = new Queue<TreeNode>();
        kuyruk.Enqueue(kok);

        bool saganSola = false;

        while (kuyruk.Count > 0)
        {
            int seviyeBoyutu = kuyruk.Count;
            List<int> seviyeDegerleri = new List<int>();

            for (int i = 0; i < seviyeBoyutu; i++)
            {
                TreeNode dugum = kuyruk.Dequeue();
                seviyeDegerleri.Add(dugum.deger);

                if (dugum.sol != null)
                {
                    kuyruk.Enqueue(dugum.sol);
                }

                if (dugum.sag != null)
                {
                    kuyruk.Enqueue(dugum.sag);
                }
            }

            if (saganSola)
            {
                seviyeDegerleri.Reverse();
            }

            sonuc.Add(seviyeDegerleri);
            saganSola = !saganSola;
        }

        return sonuc;
    }
}
