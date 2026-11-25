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

// Yaklasim 2: Recursive DFS (derinlik oncelikli, seviye indeksi tasiyarak)
// Agaci derinlik oncelikli gezip, her dugumu bulundugu seviyenin listesine ekliyoruz.
// Sonunda tek indeksli seviyeleri ters cevirerek zigzag etkisini olusturuyoruz.
// Zaman Karmasikligi: O(n) - her dugume bir kez ugranir
// Alan Karmasikligi: O(n) - cagri yigini ve sonuc listesi icin

public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode kok)
    {
        List<List<int>> sonuc = new List<List<int>>();

        DerinlikGez(kok, 0, sonuc);

        for (int i = 1; i < sonuc.Count; i += 2)
        {
            sonuc[i].Reverse();
        }

        IList<IList<int>> donusSonucu = new List<IList<int>>();

        foreach (List<int> seviye in sonuc)
        {
            donusSonucu.Add(seviye);
        }

        return donusSonucu;
    }

    private void DerinlikGez(TreeNode dugum, int seviyeIndeksi, List<List<int>> sonuc)
    {
        if (dugum == null)
        {
            return;
        }

        if (sonuc.Count == seviyeIndeksi)
        {
            sonuc.Add(new List<int>());
        }

        sonuc[seviyeIndeksi].Add(dugum.deger);

        DerinlikGez(dugum.sol, seviyeIndeksi + 1, sonuc);
        DerinlikGez(dugum.sag, seviyeIndeksi + 1, sonuc);
    }
}
