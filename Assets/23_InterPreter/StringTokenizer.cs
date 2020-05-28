using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringTokenizer
{
    private string[] words;
    private int count = 0;

    public StringTokenizer(string text)
    {
        words = text.Split(' ');
    }

    public bool hasMoreTokens()
    {
        if (words.Length > count)
        {
            return true;

        }
        else
        {
            count = 0;
            return false;
        }
    }

    public string nextToken()
    {
        string current_words = words[count];
        count++;
        return current_words;
    }
}
