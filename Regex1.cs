using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings_and_collections
{
    class Regex1
    {
        public static void Phone(string Path)
        {
           // var PhoneNumber = new List<string>();
            string pattern = "\\(\\d{3}\\)\\s\\d{3}-\\d{2}-\\d{2}";
            Regex rg = new Regex(pattern);
            string[] array1 = Directory.GetFiles(Path, "*.txt");
            foreach (string File in array1)
            {
                string str = string.Empty;
                using (System.IO.StreamReader reader = System.IO.File.OpenText(File))
                {
                    str = reader.ReadToEnd();
                }
                MatchCollection matchedAuthors = rg.Matches(str);
                foreach (Match match in matchedAuthors)
                {
                    //var Result = Regex.Replace(match.Value, pattern, "993020"); ;
                    // Result = Regex.Replace(match, pattern, "993020");
                    string Fin = str.Replace(match.Value, "90381910");
                    using (StreamWriter file = new StreamWriter(File))
                    {
                        file.Write(Fin);
                    }
                }
            }
        }
    }
}
