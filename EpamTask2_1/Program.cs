using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextConvertion;
using TextPartsClasses.Classes;
using TextPartsClasses.Interfaces;

namespace EpamTask2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append("qq");
            Console.WriteLine(builder.ToString());
            string s2 = "ert";
            builder.Append(s2);
            Console.WriteLine(builder.ToString());
            Console.ReadKey();
        }
    }
}
