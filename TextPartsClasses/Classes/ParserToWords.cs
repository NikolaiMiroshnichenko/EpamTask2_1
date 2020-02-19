using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextPartsClasses.Classes
{
    public class ParserToWords
    {
        public static List<Symbol> ParseToSymbols(string text)

        {
            int countOfOutLoop = 0;
            List<Symbol> list = new List<Symbol>();
            for (int i = 0; i < text.Length; i++)
            {
                string word = "";
                var builder = new StringBuilder();
                while (Regex.IsMatch(text[i].ToString(), @"[A-Za-z]"))
                {
                   word = (builder.Append(text[i].ToString()).ToString());
                }

                
                /*int idCount = 1;
                if (Regex.IsMatch(text[i].ToString(), @"[A - Za - z]"))
                {
                    list.Add(new Symbol { value = text[i].ToString(), Id = idCount });
                    idCount++;
                }*/
            }
            return list;
        }
    }
}
