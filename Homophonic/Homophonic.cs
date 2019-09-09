using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homophonic
{
    public class Homophonic
    {
        public Dictionary<char, int[]> TableLetters { get; set; } = new Dictionary<char, int[]>();
        public string Enctyption(string message)
        {
            string result = "";
            InitilizeTable();

            int[] userNumbers = new int[52];
            foreach (var letter in message)
            {
                if (!userNumbers.Contains(TableLetters[letter][0]))
                {
                    result += TableLetters[letter][0];
                }
                else
                {
                    result += TableLetters[letter][1];
                }
                result += " ";
            }

            return result;
        }

        public void InitilizeTable()
        {
            int[] existNumber = new int[52];
            Random random = new Random();
            for (int i = 'a', j = 0; i <= 'z'; i++)
            {
                int number1;
                int number2;
                int[] numbers = new int[2];
                do
                {
                    number1 = random.Next(0, 100);
                    number2 = random.Next(0, 100);
                } while (existNumber.Contains(number1) || existNumber.Contains(number2));
                numbers[0] = number1;
                numbers[1] = number2;
                TableLetters.Add((char)i, numbers);
                existNumber[j++] = number1;
                existNumber[j++] = number2;
            }
        }
    }
}
