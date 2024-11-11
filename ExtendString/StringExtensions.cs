using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {

        // static field // variavel de classe
        private static  readonly Random _random;


        // static constructor
        // not called by us!
        static StringExtensions()
        {
            _random = new Random();
        }

        // 
        public static string ToRandomCase(this string s)
        {
            //return null;
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                // 1º caso usa a 1ª possibilidade
                // 2º caso usa a 2ª possibilidade
                char rc = _random.NextDouble
                () < 0.5 ? char.ToUpper(c) : char.ToLower(c);

                sb.Append(rc);

            }

            // return string builder as string
            return sb.ToString();

        }
        
    }
}