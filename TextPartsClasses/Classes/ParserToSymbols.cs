using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextPartsClasses.Classes
{
    public class ParserToSymbols
    {
        public static List<Symbol> ParseToSymbols(string text)

        {
            List<Symbol> list = new List<Symbol>();
            for (int i = 0; i < text.Length; i++)
            {
                int idCount = 1;
                if (Regex.IsMatch(text[i].ToString(), @"[A - Za - z]"))
                {
                    list.Add(new Symbol { value = text[i].ToString(), Id = idCount });
                    idCount++;
                }
            }
            return list;
        }
    }
}
