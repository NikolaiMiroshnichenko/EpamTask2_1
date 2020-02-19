using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextPartsClasses.Classes
{
    public class ParserToDigits
    {
        public static List<Digit> ParseToDigit(string text)

        {
            List<Digit> list = new List<Digit>();
            for (int i = 0; i < text.Length; i++)
            {
                int idCount = 1;
                if (Regex.IsMatch(text[i].ToString(), @"[0-9]"))
                {
                    list.Add(new Digit { value = text[i].ToString(), Id = idCount });
                    idCount++;
                }
            }
            return list;
        }
    }
}
