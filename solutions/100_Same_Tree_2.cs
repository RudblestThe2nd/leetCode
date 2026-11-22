// 100 - Same Tree - Easy
// Task: Determine whether two binary trees have identical structure and node values.
// Official link: https://leetcode.com/problems/same-tree/
// Difficulty: Easy
// Question number: 100
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) BFS, kuyruk (queue) kullanarak eslesen dugum ciftlerini karsilastirma.
// Iki agacin kok dugumleri kuyruga ciftler halinde eklenir, her adimda cift kontrol edilir.
// Zaman Karmasikligi: O(n) - kucuk agacin dugum sayisi kadar kuyruk islemi yapilir.
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var kuyruk = new Queue<(TreeNode birinci, TreeNode ikinci)>();

        kuyruk.Enqueue((p, q));

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

            kuyruk.Enqueue((cift.birinci.sol, cift.ikinci.sol));
            kuyruk.Enqueue((cift.birinci.sag, cift.ikinci.sag));
        }

        return true;
    }
}
