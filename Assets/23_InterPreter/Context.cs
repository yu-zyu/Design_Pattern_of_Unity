using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterPreterPattern
{


    public class Context
    {
        private StringTokenizer tokenizer;
        private string current_Token;

        public string[] SrtingTokenizer(string text)
        {
            string[] words = text.Split(' ');

            return words; 
        }

        public Context(string text)
        {
            tokenizer = new StringTokenizer(text);
            nextToken();
        }

        public string nextToken()
        {
            if (tokenizer.hasMoreTokens())
            {
                current_Token = tokenizer.nextToken();
            }
            else
            {
                current_Token = null;
            }
            return current_Token;
        }

        public string currentToken()
        {
            return current_Token;
        }

        public void skipToken(string token)
        {
            if (!token.Equals(current_Token))
            {
                throw new ParseException("Warning: " + token + " is expected, but " + current_Token + " is found.");
            }
            nextToken();
        }

        public int currentNumber()
        {
            int number = 0;
            try
            {
                number = int.Parse(current_Token);
            } catch (Exception e)
            {
                throw new ParseException("Warnung: " + e);
            }
            return number;
        }

    }
}
