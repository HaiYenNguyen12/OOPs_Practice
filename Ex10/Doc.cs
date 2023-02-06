using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Doc
    {
        public string St { get; set; }

        public Doc()
        {
            St= string.Empty;
        }
        public Doc(string st)
        {
            St = st;
        }

        public int CountWords()
        {
            char[] chars = new char[] {' ', '\r', '\n'};
            return this.St.Split(chars, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountALetter()
        {
           return this.St.Count(x => x =='a' || x == 'A');
        }

        public string FormatDocs()
        {
            this.St = this.St.Trim();
            return Regex.Replace(this.St, @"\s+", " ");
        }
    }
}
