using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
             string a = "";
            foreach (char letter in orig)
            {
                string b = "";
                for (int i = 0; i < n; i++)
                {
                    b += letter;
                }
                a += b;
            }
            return a;
        }
    }
}
