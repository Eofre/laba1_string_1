using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    public class Logic
    {
        public static string SwapChar(string word)
        {

            StringBuilder word2 = new StringBuilder(word);

            char charWord;
            for (int i = 0; i < word.Length; i += 2)
            {
                charWord = word2[i];
                word2[i] = word2[i + 1];
                word2[i + 1] = charWord;
            }

            var message = "Итоговое слово: " + word2;

            return message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string word = "ИРНИТУ";
            Console.WriteLine("Начально слово: " + word);
            var message = Logic.SwapChar(word);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
