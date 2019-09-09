using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere
{
    public class Vigenere
    {
        public char[] TableLetters { get; set; } = new char[26];
        public string Enctyption(string message, string slogan)
        {
            string result = "";
            slogan = RemoveRepeatingLetters(slogan);
            InitilizeTable();
            int keyword_index = 0;
            int N = TableLetters.Length;

            foreach (var letter in message)
            {
                int index = (Array.IndexOf(TableLetters, letter) +
                Array.IndexOf(TableLetters, slogan[keyword_index])) % N;
                result += TableLetters[index];

                keyword_index++;

                if (keyword_index == slogan.Length)
                    keyword_index = 0;
            }

            return result;
        }

        public string RemoveRepeatingLetters(string text)
        {
            return new string(text.Distinct().ToArray());
        }

        public void InitilizeTable()
        {
            for (int i = 'a', j = 0; i <= 'z'; i++, j++)
            {
                TableLetters[j] = (char) i;
            }
        }
    }
}
