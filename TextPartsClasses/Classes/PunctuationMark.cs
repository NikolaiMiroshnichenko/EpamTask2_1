using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextPartsClasses.Interfaces;

namespace TextPartsClasses.Classes
{
    public class PunctuationMark: ISentenceItem
    {
        public string value { get; set; }
        public int Id { get; set; }
    }
}
