using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public class CaesarCipher
    {
        public string Enctyption (string message, int shift)
        {
            string result = "";
            foreach (var letter in message)
            {
                if (letter == 32) // Space
                {
                    result.Append(' ');
                }
                else
                { 
                    char newLetter = (char) (letter + shift);

                    if (newLetter > 90 && newLetter < 97) // if it`s last letters
                    {
                        newLetter = (char)(64 + (newLetter - 90));
                    }
                    else if (newLetter > 122)  // if it`s last letters
                    {
                        newLetter = (char)(96 + (newLetter - 122));
                    }

                    result += newLetter;
                }
            }

            return result;
        }
    }
}
