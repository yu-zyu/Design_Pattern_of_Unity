using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using InterPreterPattern_exercises1;

namespace InterPreterPattern_language_exercises1
{
    public class Context : ExecutorFactory
    {
        private ExecutorFactory factory;
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

        public void setExecutorFactory(ExecutorFactory factory)
        {
            this.factory = factory;
        }

        public Executor createExecutor(string name)
        {
            return factory.createExecutor(name);
        }

    }
}
