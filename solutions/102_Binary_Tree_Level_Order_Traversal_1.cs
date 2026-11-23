// 102 - Binary Tree Level Order Traversal - Medium
// Task: Return the level-order traversal of a binary tree from top to bottom.
// Official link: https://leetcode.com/problems/binary-tree-level-order-traversal/
// Difficulty: Medium
// Question number: 102
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) BFS, kuyruk (queue) kullanarak seviye seviye gezme.
// Her seviyedeki dugum sayisi once sabitlenir, o kadar dugum kuyruktan cikarilip yeni seviye olusturulur.
// Zaman Karmasikligi: O(n) - her dugum bir kez kuyruga eklenip bir kez cikarilir.
// Alan Karmasikligi: O(n) - kuyruk en kotu durumda bir seviyedeki tum dugumleri tutabilir.

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
    public IList<IList<int>> LevelOrder(TreeNode kok)
    {
        var sonuc = new List<IList<int>>();

        if (kok == null)
        {
            return sonuc;
        }

        var kuyruk = new Queue<TreeNode>();
        kuyruk.Enqueue(kok);

        while (kuyruk.Count > 0)
        {
            int seviyeUzunlugu = kuyruk.Count;
            var seviyeListesi = new List<int>();

            for (int i = 0; i < seviyeUzunlugu; i++)
            {
                var dugum = kuyruk.Dequeue();

                seviyeListesi.Add(dugum.deger);

                if (dugum.sol != null)
                {
                    kuyruk.Enqueue(dugum.sol);
                }

                if (dugum.sag != null)
                {
                    kuyruk.Enqueue(dugum.sag);
                }
            }

            sonuc.Add(seviyeListesi);
        }

        return sonuc;
    }
}
