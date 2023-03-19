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
            string PathElement = @"C:\";
            Console.WriteLine("Введите путь к файлу");
            string Path = Console.ReadLine();
            DictionaryErrors Errors = new DictionaryErrors();
            Errors.Words(PathElement + Path);
            Regex1.Phone(PathElement + Path);
            Console.ReadLine();


        }
    }
}
