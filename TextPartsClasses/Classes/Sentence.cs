using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextConvertion;
using TextPartsClasses.Interfaces;
using System.Text.RegularExpressions;

namespace TextPartsClasses.Classes
{
    public class Sentence
    {
        public List<ISentenceItem> sentenceItems = new List<ISentenceItem>();
        public string SentenceValue { get; set; }
        public int SentenceId { get; set; }
    }
}
