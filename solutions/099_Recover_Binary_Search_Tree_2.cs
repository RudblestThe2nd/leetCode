// 99 - Recover Binary Search Tree - Medium
// Task: Recover a binary search tree where exactly two node values were swapped by mistake.
// Official link: https://leetcode.com/problems/recover-binary-search-tree/
// Difficulty: Medium
// Question number: 99
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Iteratif (dongu tabanli) inorder gezinme, kendi yiginimizla, listeye toplamadan aninda karsilastirma.
// Onceki ziyaret edilen dugum tutulur; sira bozulan ilk ve son cift bulunur, sonunda degerleri takas edilir.
// Zaman Karmasikligi: O(n) - her dugum bir kez yigina eklenip bir kez cikarilir.
// Alan Karmasikligi: O(n) - yigin en kotu durumda tum dugumleri tutabilir.

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
        var yigin = new Stack<TreeNode>();
        TreeNode simdiki = kok;
        TreeNode oncekiDugum = null;
        TreeNode birinciYanlis = null;
        TreeNode ikinciYanlis = null;

        while (simdiki != null || yigin.Count > 0)
        {
            while (simdiki != null)
            {
                yigin.Push(simdiki);
                simdiki = simdiki.sol;
            }

            simdiki = yigin.Pop();

            if (oncekiDugum != null && oncekiDugum.deger > simdiki.deger)
            {
                if (birinciYanlis == null)
                {
                    birinciYanlis = oncekiDugum;
                    ikinciYanlis = simdiki;
                }
                else
                {
                    ikinciYanlis = simdiki;
                }
            }

            oncekiDugum = simdiki;

            simdiki = simdiki.sag;
        }

        if (birinciYanlis != null && ikinciYanlis != null)
        {
            int gecici = birinciYanlis.deger;
            birinciYanlis.deger = ikinciYanlis.deger;
            ikinciYanlis.deger = gecici;
        }
    }
}
