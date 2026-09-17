// 41 - First Missing Positive - Hard
// Task: Find the smallest missing positive integer from an unsorted array, ideally in linear time and constant extra space.
// Official link: https://leetcode.com/problems/first-missing-positive/
// Difficulty: Hard
// Question number: 41
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim 2: Yerinde (In-place) Indeksleme / Cyclic Sort Mantigi
// n elemanli dizide cevap her zaman 1 ile n+1 arasindadir. Her sayiyi, degeri
// kadar olan indekse (deger - 1) yerlestirmeye calisarak diziyi yerinde
// duzenliyoruz. Sonra ilk "yanlis yerdeki" indeksi tarayarak cevabi buluyoruz.
// Zaman Karmasikligi: O(n)
// Alan Karmasikligi: O(1) (ekstra veri yapisi kullanilmiyor, dizi yerinde degistiriliyor)

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int uzunluk = nums.Length;

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            // nums[indeks] degeri 1..uzunluk araliginda ve dogru yerinde degilse takas et
            while (nums[indeks] > 0 && nums[indeks] <= uzunluk && nums[nums[indeks] - 1] != nums[indeks])
            {
                int hedefIndeks = nums[indeks] - 1;

                int gecici = nums[indeks];
                nums[indeks] = nums[hedefIndeks];
                nums[hedefIndeks] = gecici;
            }
        }

        for (int indeks = 0; indeks < uzunluk; indeks++)
        {
            if (nums[indeks] != indeks + 1)
            {
                return indeks + 1;
            }
        }

        return uzunluk + 1;
    }
}
