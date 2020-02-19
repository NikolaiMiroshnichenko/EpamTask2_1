using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TextPartsClasses.Classes;

namespace TextConvertion
{
    public class ParserToSentences
    {
        public static List<Sentence> SeparateToSentences()
        {
            int idCount = 1;
            string text = TxtConvertor.Convert();
            List<Sentence> list = new List<Sentence>();
            string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");
            foreach (var item in sentences)
            {
                list.Add(new Sentence { SentenceValue = item, SentenceId = idCount }) ;
                idCount++;
            }
            return list;
        }
    }
}
