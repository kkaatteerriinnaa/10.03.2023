using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] text = { "ahb", "acb", "aeb","aeeb","adcb","axed"};

            //string pattern = "[a].[b]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aba", "aca", "aea", "abba", "adca", "adea" };

            //string pattern = "[a]..[a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aba", "aca", "aea", "abba", "adca", "adea" };

            //string pattern = "[a].[^c][a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aa", "aba", "abba", "abbba", "adca", "adea" };

            //string pattern = "[a][b]+[a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aa", "aba", "abba", "abbba", "adca", "adea" };

            //string pattern = "[a][b]*[a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aa", "aba", "abba", "abbba", "adca", "adea" };

            //string pattern = "[a][b]?[a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            //string[] text = { "aa", "aba", "abba", "abbba", "adca", "adea" };

            //string pattern = "[a][^c e]*[a]";
            //Regex regex = new Regex(pattern);

            //Console.WriteLine("Регистрозависимый поиск: ");
            //foreach (string str in text)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}
            //Console.WriteLine();


            string[] text = { "ab", "abab", "abab", "abababab", "abea" };

            string pattern = "[ab]+";
            Regex regex = new Regex(pattern);

            Console.WriteLine("Регистрозависимый поиск: ");
            foreach (string str in text)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            }
            Console.WriteLine();
        }
    }
}
