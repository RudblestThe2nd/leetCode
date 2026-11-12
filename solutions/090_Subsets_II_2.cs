// 90 - Subsets II - Medium
// Task: Return all unique subsets of an integer array that may contain duplicates.
// Official link: https://leetcode.com/problems/subsets-ii/
// Difficulty: Medium
// Question number: 90
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Bit maskeleme (tum kombinasyonlari tek tek deneme) + HashSet ile tekrar eleme
// Zaman Karmasikligi: O(2^n * n) - her maske icin dizi taranir ve anahtar olusturulur
// Alan Karmasikligi: O(2^n * n) - tum alt kumeler ve tekillik kontrolu icin
// Aciklama: Diziyi sirliyoruz, ardindan 0'dan 2^n - 1'e kadar her sayiyi bir
// bit maskesi olarak yorumlayip, o maskede acik olan bitlere karsilik gelen
// elemanlardan bir alt kume olusturuyoruz. Ayni alt kumenin metin temsilini
// bir kume (HashSet) icinde tutarak tekrarlari eliyoruz.
public class Solution
{
    public System.Collections.Generic.IList<System.Collections.Generic.IList<int>> SubsetsWithDup(int[] dizi)
    {
        System.Array.Sort(dizi);

        var tumSonuclar = new System.Collections.Generic.List<System.Collections.Generic.IList<int>>();
        var gorulenAnahtarlar = new System.Collections.Generic.HashSet<string>();

        int uzunluk = dizi.Length;
        int toplamMaske = 1 << uzunluk;

        for (int maske = 0; maske < toplamMaske; maske++)
        {
            var geciciKume = new System.Collections.Generic.List<int>();

            for (int bitIndeksi = 0; bitIndeksi < uzunluk; bitIndeksi++)
            {
                if ((maske & (1 << bitIndeksi)) != 0)
                {
                    geciciKume.Add(dizi[bitIndeksi]);
                }
            }

            string anahtar = string.Join(",", geciciKume);

            if (!gorulenAnahtarlar.Contains(anahtar))
            {
                gorulenAnahtarlar.Add(anahtar);
                tumSonuclar.Add(geciciKume);
            }
        }

        return tumSonuclar;
    }
}
