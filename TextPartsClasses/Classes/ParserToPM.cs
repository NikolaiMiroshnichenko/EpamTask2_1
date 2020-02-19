using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TextPartsClasses.Classes;

namespace TextConvertion
{
    public class ParseToPM
    {
        public static List<PunctuationMark> ParseToPm(string text)

        {
            List<PunctuationMark> list = new List<PunctuationMark>();
            for (int i = 0; i < text.Length; i++)
            {
                int idCount = 1;
                if (Regex.IsMatch(text[i].ToString(), @"\,|\.|\?|\!"))
                {
                    list.Add(new PunctuationMark { value = text[i].ToString(), Id = idCount });
                    idCount++;
                }
            }
            return list;
        }
    }
}
