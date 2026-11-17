// 95 - Unique Binary Search Trees II - Medium
// Task: Generate all structurally unique binary search trees storing values 1 through n.
// Official link: https://leetcode.com/problems/unique-binary-search-trees-ii/
// Difficulty: Medium
// Question number: 95
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bellekleme (memoization) ile ust-asagi (top-down) dinamik programlama.
// Ayni (baslangic, bitis) araligi icin uretilen agac listesi harita (dictionary) icinde saklanip tekrar hesaplanmaz.
// Zaman Karmasikligi: O(4^n / n^1.5) - farkli aralik sayisi O(n^2) ama agac birlestirme baskin faktor.
// Alan Karmasikligi: O(4^n / n^1.5) - bellekleme haritasi ve uretilen agaclarin toplam boyutu.

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
    private Dictionary<string, List<TreeNode>> bellek;

    public IList<TreeNode> GenerateTrees(int sayi)
    {
        bellek = new Dictionary<string, List<TreeNode>>();

        if (sayi == 0)
        {
            return new List<TreeNode>();
        }

        return Uret(1, sayi);
    }

    private List<TreeNode> Uret(int baslangic, int bitis)
    {
        if (baslangic > bitis)
        {
            return new List<TreeNode> { null };
        }

        string anahtar = baslangic + "-" + bitis;

        if (bellek.ContainsKey(anahtar))
        {
            return bellek[anahtar];
        }

        var sonuc = new List<TreeNode>();

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

        bellek[anahtar] = sonuc;

        return sonuc;
    }
}
