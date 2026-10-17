// 71 - Simplify Path - Medium
// Task: Simplify an absolute Unix-style file path to its canonical form.
// Official link: https://leetcode.com/problems/simplify-path/
// Difficulty: Medium
// Question number: 71
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Manuel string tarama (Split kullanmadan, indeks ilerletme ile),
// sonuc yine bir yigin (Stack<string>) uzerinde tutulur
// Zaman Karmasikligi: O(n) - n yolun uzunlugu
// Alan Karmasikligi: O(n) - yigin ve gecici parca icin
// Aciklama: Yol karakter karakter taranir, her '/' karakterinde o ana kadar
// biriken parca degerlendirilir. Split fonksiyonu kullanilmadan indeksler
// elle ilerletilerek parcalar cikarilir.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string SimplifyPath(string yol)
    {
        Stack<string> yigin = new Stack<string>();
        int indeks = 0;
        int uzunluk = yol.Length;

        while (indeks < uzunluk)
        {
            while (indeks < uzunluk && yol[indeks] == '/')
            {
                indeks++;
            }

            int parcaBaslangici = indeks;

            while (indeks < uzunluk && yol[indeks] != '/')
            {
                indeks++;
            }

            if (indeks > parcaBaslangici)
            {
                string parca = yol.Substring(parcaBaslangici, indeks - parcaBaslangici);

                if (parca == ".")
                {
                    // hicbir sey yapilmaz, gecerli klasorde kalinir
                }
                else if (parca == "..")
                {
                    if (yigin.Count > 0)
                    {
                        yigin.Pop();
                    }
                }
                else
                {
                    yigin.Push(parca);
                }
            }
        }

        if (yigin.Count == 0)
        {
            return "/";
        }

        List<string> siraliListe = new List<string>(yigin);
        siraliListe.Reverse();

        StringBuilder sonucOlusturucu = new StringBuilder();
        foreach (string klasor in siraliListe)
        {
            sonucOlusturucu.Append('/');
            sonucOlusturucu.Append(klasor);
        }

        return sonucOlusturucu.ToString();
    }
}
