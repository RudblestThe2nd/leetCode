// 101 - Symmetric Tree - Easy
// Task: Determine whether a binary tree is a mirror of itself.
// Official link: https://leetcode.com/problems/symmetric-tree/
// Difficulty: Easy
// Question number: 101
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) BFS, kuyruk (queue) ile karsilikli dugum ciftlerini kontrol etme.
// Kuyruga hep ayna olmasi gereken iki dugum birlikte eklenir ve degerleri karsilastirilir.
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
    public bool IsSymmetric(TreeNode kok)
    {
        if (kok == null)
        {
            return true;
        }

        var kuyruk = new Queue<(TreeNode birinci, TreeNode ikinci)>();

        kuyruk.Enqueue((kok.sol, kok.sag));

        while (kuyruk.Count > 0)
        {
            var cift = kuyruk.Dequeue();

            if (cift.birinci == null && cift.ikinci == null)
            {
                continue;
            }

            if (cift.birinci == null || cift.ikinci == null)
            {
                return false;
            }

            if (cift.birinci.deger != cift.ikinci.deger)
            {
                return false;
            }

            kuyruk.Enqueue((cift.birinci.sol, cift.ikinci.sag));
            kuyruk.Enqueue((cift.birinci.sag, cift.ikinci.sol));
        }

        return true;
    }
}
