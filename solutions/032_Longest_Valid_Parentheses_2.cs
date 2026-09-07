// 32 - Longest Valid Parentheses - Hard
// Task: Find the length of the longest substring of parentheses that forms a valid expression.
// Official link: https://leetcode.com/problems/longest-valid-parentheses/
// Difficulty: Hard
// Question number: 32
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yigin (Stack) Tabanli
// Zaman Karmasikligi: O(n) - dizi bir defa taranir
// Alan Karmasikligi: O(n) - indeksleri tutan yigin icin
// Turkce aciklama: Yigina baslangicta -1 tabanindan indeks konur. Acilis parantezinde
// indeks yigina itilir, kapanis parantezinde yigindan bir eleman cikarilir; yigin bosalirsa
// suanki indeks yeni taban olarak yigina konur, degilse suanki indeks ile yigin tepesi
// arasindaki fark en uzun gecerli uzunluk adayi olarak degerlendirilir.

using System;
using System.Collections.Generic;

public class Solution
{
    public int LongestValidParentheses(string metin)
    {
        var yigin = new Stack<int>();
        yigin.Push(-1);

        int enUzunSonuc = 0;

        for (int i = 0; i < metin.Length; i++)
        {
            if (metin[i] == '(')
            {
                yigin.Push(i);
            }
            else
            {
                yigin.Pop();

                if (yigin.Count == 0)
                {
                    yigin.Push(i);
                }
                else
                {
                    int suankiUzunluk = i - yigin.Peek();
                    enUzunSonuc = Math.Max(enUzunSonuc, suankiUzunluk);
                }
            }
        }

        return enUzunSonuc;
    }
}
