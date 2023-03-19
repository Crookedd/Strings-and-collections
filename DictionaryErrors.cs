using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_collections
{
    class DictionaryErrors
    {
        public void Words(string Path)
        {
            var Errors = new List<string>() { "привэт","превет","првиет", "сдравсствуй", "здравствй"};
            string[] array1 = Directory.GetFiles(Path, "*.txt");
            for(int Index = 0; Index < Errors.Count;++Index)
            {
                if (Errors[Index] == "привэт" || Errors[Index] == "превет" || Errors[Index] == "првиет")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "привет");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }
                if (Errors[Index] == "сдравсствуй" || Errors[Index] == "здравствй")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "здравствуй");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }

            }   

        }
    }
}
