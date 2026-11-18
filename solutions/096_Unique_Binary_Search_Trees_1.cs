// 96 - Unique Binary Search Trees - Medium
// Task: Count how many structurally unique binary search trees can be built with n distinct values.
// Official link: https://leetcode.com/problems/unique-binary-search-trees/
// Difficulty: Medium
// Question number: 96
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Asagi-yukari (bottom-up) dinamik programlama, tek boyutlu dizi ile.
// dizi[i], i dugumlu benzersiz BST sayisini tutar; her kok secimi icin sol*sag carpimlari toplanir.
// Zaman Karmasikligi: O(n^2) - her i icin 0..i-1 arasi kok secenekleri denenir.
// Alan Karmasikligi: O(n) - sadece bir boyutlu sonuc dizisi kullanilir.

public class Solution
{
    public int NumTrees(int sayi)
    {
        int[] dizi = new int[sayi + 1];

        dizi[0] = 1;
        dizi[1] = 1;

        for (int dugumSayisi = 2; dugumSayisi <= sayi; dugumSayisi++)
        {
            int toplam = 0;

            for (int kokIndeksi = 1; kokIndeksi <= dugumSayisi; kokIndeksi++)
            {
                int solSayisi = dizi[kokIndeksi - 1];
                int sagSayisi = dizi[dugumSayisi - kokIndeksi];

                toplam += solSayisi * sagSayisi;
            }

            dizi[dugumSayisi] = toplam;
        }

        return dizi[sayi];
    }
}
