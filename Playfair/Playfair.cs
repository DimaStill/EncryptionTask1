using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playfair
{
    public class Playfair
    {
        public char[,] TableLetters;
        public int size;
        public string Encryption(string message, string slogan)
        {
            string result = "";
            List<string> bigrams = new List<string>();
            List<string> resultBigrams = new List<string>();
            InitilizeTable(slogan);

            for (int i = 0; i < message.Length; i += 2)
            {
                if (i + 1 < message.Length && message[i] != message[i + 1])
                {
                    bigrams.Add(message[i].ToString() + message[i + 1]);
                }
                else
                {
                    bigrams.Add(message[i] + "x");
                }
            }

            foreach (string bigram in bigrams)
            {
                string encryptBigram = "";
                int[] position1 = new int[2];
                int[] position2 = new int[2];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (TableLetters[i, j] == bigram[0])
                        {
                            position1[0] = i;
                            position1[1] = j;
                        }
                        else if (TableLetters[i, j] == bigram[1])
                        {
                            position2[0] = i;
                            position2[1] = j;
                        }
                    }
                }

                if (position1[1] == position2[1])
                {
                    if (position1[1] >= size - 1)
                    {
                        position1[1] = 0;
                    }
                    else
                    {
                        position1[1] += 1;
                    }

                    if (position2[1] >= size - 1)
                    {
                        position2[1] = 0;
                    }
                    else
                    {
                        position2[1] += 1;
                    }
                    resultBigrams.Add(
                        TableLetters[position1[0], position1[1]].ToString() + TableLetters[position2[0], position2[1]]
                    );
                }
                else if (position1[0] == position2[0])
                {
                    if (position1[0] >= size - 1)
                    {
                        position1[0] = 0;
                    }
                    else
                    {
                        position2[0] += 1;
                    }

                    if (position2[0] >= size - 1)
                    {
                        position2[0] = 0;
                    }
                    else
                    {
                        position2[0] += 1;
                    }
                    resultBigrams.Add(
                        TableLetters[position1[0], position1[1]].ToString() + TableLetters[position2[0], position2[1]]
                    );
                }
                else
                {
                    resultBigrams.Add(
                        TableLetters[position1[0], position2[1]].ToString() + TableLetters[position2[0], position1[1]]
                    );
                }
            }

            foreach (var str in resultBigrams)
            {
                result += $"{str} ";
            }

            return result;
        }

        public void InitilizeTable(string slogan)
        {
            size = Convert.ToInt32(Math.Ceiling(Math.Sqrt(26 + slogan.Length)));
            TableLetters = new char[size, size];
            for (int l = 'a', k = 0, i = 0, j = 0; l <= 'z'; l++, k++, j++)
            {
                if (slogan.Length > i * size + j)
                {
                    l--;
                    TableLetters[i, j] = slogan[k];
                }
                else if (!slogan.Contains((char)l))
                {
                    TableLetters[i, j] = (char)l;
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
