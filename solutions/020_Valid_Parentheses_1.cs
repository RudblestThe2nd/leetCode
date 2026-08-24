// 20 - Valid Parentheses - Easy
// Task: Check whether brackets in a string are correctly opened and closed in order.
// Official link: https://leetcode.com/problems/valid-parentheses/
// Difficulty: Easy
// Question number: 20
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Yigin (Stack) tabanli - acilan parantezleri yigina koy,
// kapanan parantez gelince yigin tepesiyle eslesip eslesmedigini kontrol et.
// Zaman Karmasikligi: O(n) - string bir kez taranir.
// Alan Karmasikligi: O(n) - en kotu durumda tum karakterler yigina girer.

using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        var yigin = new Stack<char>();

        foreach (char karakter in s)
        {
            if (karakter == '(' || karakter == '[' || karakter == '{')
            {
                yigin.Push(karakter);
            }
            else
            {
                if (yigin.Count == 0)
                {
                    return false;
                }

                char tepe = yigin.Pop();

                if (karakter == ')' && tepe != '(')
                {
                    return false;
                }

                if (karakter == ']' && tepe != '[')
                {
                    return false;
                }

                if (karakter == '}' && tepe != '{')
                {
                    return false;
                }
            }
        }

        return yigin.Count == 0;
    }
}
