// 95 - Unique Binary Search Trees II - Medium
// Task: Generate all structurally unique binary search trees storing values 1 through n.
// Official link: https://leetcode.com/problems/unique-binary-search-trees-ii/
// Difficulty: Medium
// Question number: 95
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) bolme - her deger sirayla kok olarak secilir,
// sol ve sag araliklardan uretilen tum alt agac kombinasyonlari birlestirilir.
// Zaman Karmasikligi: O(4^n / n^1.5) - Katalan sayisi buyumesine bagli agac sayisi.
// Alan Karmasikligi: O(4^n / n^1.5) - uretilen tum agaclarin saklanmasi icin.

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
    public IList<TreeNode> GenerateTrees(int sayi)
    {
        if (sayi == 0)
        {
            return new List<TreeNode>();
        }

        return Uret(1, sayi);
    }

    private List<TreeNode> Uret(int baslangic, int bitis)
    {
        var sonuc = new List<TreeNode>();

        if (baslangic > bitis)
        {
            sonuc.Add(null);
            return sonuc;
        }

        for (int kokDegeri = baslangic; kokDegeri <= bitis; kokDegeri++)
        {
            var solAgaclar = Uret(baslangic, kokDegeri - 1);
            var sagAgaclar = Uret(kokDegeri + 1, bitis);

            foreach (var solAgac in solAgaclar)
            {
                foreach (var sagAgac in sagAgaclar)
                {
                    var kok = new TreeNode(kokDegeri);
                    kok.sol = solAgac;
                    kok.sag = sagAgac;

                    sonuc.Add(kok);
                }
            }
        }

        return sonuc;
    }
}
