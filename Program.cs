using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings_and_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string PathElement = @"C:\";
            Console.WriteLine("Введите путь к файлу");
            string Path = Console.ReadLine();
            DictionaryErrors Errors = new DictionaryErrors();
            Errors.Words(PathElement + Path);*/
            var test2 = new List<string>() { "(012) 345-67-89", "+79034567 89" };
            string pattern = "\\(\\d{3}\\)\\s\\d{3}-\\d{2}-\\d{2}";

            for (int i = 0; i < test2.Count; i++)
            {
                if (Regex.IsMatch(test2[i], pattern, RegexOptions.IgnoreCase))
                {
                    string contect;
                    Console.WriteLine(test2[i]);
                    contect = Regex.Replace(test2[i],pattern, "993020");
                    Console.WriteLine(contect);

                }
            }
            Console.ReadLine();


        }
    }
}
