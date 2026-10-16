// 71 - Simplify Path - Medium
// Task: Simplify an absolute Unix-style file path to its canonical form.
// Official link: https://leetcode.com/problems/simplify-path/
// Difficulty: Medium
// Question number: 71
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yigin (Stack<string>) tabanli, Split ile parcalara ayirma
// Zaman Karmasikligi: O(n) - n yolun uzunlugu
// Alan Karmasikligi: O(n) - yigin ve sonuc icin
// Aciklama: Yol '/' karakterine gore parcalara ayrilir. Bos parcalar ve "."
// yok sayilir, ".." gorulunce yigindan bir eleman cikarilir (varsa), diger
// tum parcalar yigina eklenir. Sonunda yigindaki elemanlar birlestirilir.

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string SimplifyPath(string yol)
    {
        string[] parcalar = yol.Split('/');
        Stack<string> yigin = new Stack<string>();

        foreach (string parca in parcalar)
        {
            if (parca.Length == 0 || parca == ".")
            {
                continue;
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
