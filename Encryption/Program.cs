using Caesar_cipher;
using SloganCipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        public static string Surname { get; set; } = "Karaiev";
        static void Main(string[] args)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            SloganCipher.SloganCipher sloganCipher = new SloganCipher.SloganCipher();
            PolybiusSquare.PolybiusSquare polybiusSquare = new PolybiusSquare.PolybiusSquare();
            TrithemiusСipher.TrithemiusCipher trithemiusCipher = new TrithemiusСipher.TrithemiusCipher();
            Playfair.Playfair playfair = new Playfair.Playfair();
            Homophonic.Homophonic homophonic = new Homophonic.Homophonic();
            Vigenere.Vigenere vigenere = new Vigenere.Vigenere();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            do
            {
                Console.WriteLine("1. Ceaser cipher\n" +
                    "2. Slogan cipher\n" +
                    "3. Polybius square\n" +
                    "4. Trithemius Cipher\n" +
                    "5. Playfair\n" +
                    "6. Homophonic\n" +
                    "7. Vigenere");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Result: " + caesarCipher.Enctyption(surname, 13));
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Result: " + sloganCipher.Enctyption(surname, "dima"));
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Result: " + polybiusSquare.Encryption(surname));
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Result: " + trithemiusCipher.Encryption(surname, "dima"));
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Result: " + playfair.Encryption(surname, "dima"));
                        Console.WriteLine();
                        break;
                    case "6":
                        Console.WriteLine("Result: " + homophonic.Enctyption(surname));
                        Console.WriteLine();
                        break;
                    case "7":
                        Console.WriteLine("Result: " + vigenere.Enctyption(surname, "dima"));
                        Console.WriteLine();
                        break;
                    default:
                        continue;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
