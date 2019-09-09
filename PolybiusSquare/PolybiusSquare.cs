using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolybiusSquare
{
    public class PolybiusSquare
    {
        public char[,] TableLetters = new char[6, 6];

        public string Encryption(string message)
        {
            string result = "";
            InitilizeTable();

            foreach (char letter in message)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (TableLetters[i, j] == letter)
                        {
                            result += "" + i + j + " ";
                        }
                    }
                }
            }

            return result;
        }

        public void InitilizeTable()
        {
            TableLetters = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    TableLetters[i, j] = (char) (97 + i * 6 + j);
                }
            }
        }
    }
}
