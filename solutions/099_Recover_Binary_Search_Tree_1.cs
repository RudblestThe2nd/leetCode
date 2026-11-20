// 99 - Recover Binary Search Tree - Medium
// Task: Recover a binary search tree where exactly two node values were swapped by mistake.
// Official link: https://leetcode.com/problems/recover-binary-search-tree/
// Difficulty: Medium
// Question number: 99
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) inorder gezinme ile tum dugumleri listeye toplama.
// Inorder sirali listede artan olmayan noktalar bulunup ilgili iki dugumun degeri degistirilir.
// Zaman Karmasikligi: O(n) - agac bir kez gezilir, liste bir kez taranir.
// Alan Karmasikligi: O(n) - tum dugumleri tutan liste ve cagri yigini icin.

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
    public void RecoverTree(TreeNode kok)
    {
        var dugumler = new List<TreeNode>();

        Gez(kok, dugumler);

        TreeNode birinciYanlis = null;
        TreeNode ikinciYanlis = null;

        for (int i = 0; i < dugumler.Count - 1; i++)
        {
            if (dugumler[i].deger > dugumler[i + 1].deger)
            {
                if (birinciYanlis == null)
                {
                    birinciYanlis = dugumler[i];
                    ikinciYanlis = dugumler[i + 1];
                }
                else
                {
                    ikinciYanlis = dugumler[i + 1];
                }
            }
        }

        if (birinciYanlis != null && ikinciYanlis != null)
        {
            int gecici = birinciYanlis.deger;
            birinciYanlis.deger = ikinciYanlis.deger;
            ikinciYanlis.deger = gecici;
        }
    }

    private void Gez(TreeNode dugum, List<TreeNode> dugumler)
    {
        if (dugum == null)
        {
            return;
        }

        Gez(dugum.sol, dugumler);

        dugumler.Add(dugum);

        Gez(dugum.sag, dugumler);
    }
}
