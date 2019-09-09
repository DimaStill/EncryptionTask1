using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloganCipher
{
    public class SloganCipher
    {
        public Dictionary<char, char> TableLetters { get; set; } = new Dictionary<char, char>();
        public string Enctyption(string message, string slogan)
        {
            string result = "";
            slogan = RemoveRepeatingLetters(slogan);
            InitilizeTable(slogan);

            foreach (var letter in message)
            {
                result += TableLetters[letter];
            }

            return result;
        }

        public string RemoveRepeatingLetters(string text)
        {
            return new string(text.Distinct().ToArray());
        }

        public void InitilizeTable(string slogan)
        {
            TableLetters.Clear();
            for (int i = 'a', j = 0, k = i; i <= 'z'; i++, j++, k++)
            {
                if (slogan.Length > j)
                {
                    TableLetters.Add((char)i, slogan[j]);
                }
                else if (!slogan.Contains((char)(k - slogan.Length)))
                {
                    TableLetters.Add((char) i, (char)(k - slogan.Length));
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
