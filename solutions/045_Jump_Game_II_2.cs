// 45 - Jump Game II - Medium
// Task: Return the minimum number of jumps needed to reach the last index of an array.
// Official link: https://leetcode.com/problems/jump-game-ii/
// Difficulty: Medium
// Question number: 45
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Dinamik Programlama (Alttan Yukari, her indeks icin en iyi sonuc)
// Her indeks icin oraya en az kac sicramayla ulasilacagini hesaplariz.
// Her indeksten, ulasabildigi tum ileri konumlarin degerini guncelleriz.
// Daha yavas ama anlasilmasi daha kolay bir yontemdir.
// Zaman Karmasikligi: O(dizi.Uzunluk^2) (en kotu durum)
// Alan Karmasikligi: O(dizi.Uzunluk)

public class Solution
{
    public int Jump(int[] dizi)
    {
        int uzunluk = dizi.Length;

        int[] enAzSicrama = new int[uzunluk];

        for (int i = 1; i < uzunluk; i++)
        {
            enAzSicrama[i] = int.MaxValue;
        }

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            int erisimMesafesi = dizi[indeks];

            for (int adim = 1; adim <= erisimMesafesi && indeks + adim < uzunluk; adim++)
            {
                int hedefIndeks = indeks + adim;

                if (enAzSicrama[indeks] + 1 < enAzSicrama[hedefIndeks])
                {
                    enAzSicrama[hedefIndeks] = enAzSicrama[indeks] + 1;
                }
            }
        }

        return enAzSicrama[uzunluk - 1];
    }
}
