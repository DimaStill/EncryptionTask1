using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrithemiusСipher
{
    public class TrithemiusCipher
    {
        public char[,] TableLetters;

        public string Encryption(string message, string slogan)
        {
            string result = "";
            InitilizeTable(slogan);

            foreach (char letter in message)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (TableLetters[i, j] == letter)
                        {
                            if (i < 5)
                            {
                                result += TableLetters[i + 1, j];
                            }
                            else
                            {
                                result += TableLetters[0, j];
                            }
                        }
                    }
                }
            }

            return result;
        }

        public void InitilizeTable(string slogan)
        {
            int size = Convert.ToInt32(Math.Ceiling(Math.Sqrt(26 + slogan.Length)));
            TableLetters = new char[size, size];
            for (int l = 'a', k = 0, i = 0, j = 0; l <= 'z'; l++, k++, j++)
            {
                if (slogan.Length > i * size + j)
                {
                    l--;
                    TableLetters[i, j] = slogan[k];
                }
                else if (!slogan.Contains((char) l))
                {
                    TableLetters[i, j] = (char) l;
                }
                else
                {
                    j--;
                }
                if (j == size - 1)
                {
                    j = -1;
                    i++;
                }
            }
        }
    }
}
