using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_3_Easy_CS
{
    class aCode : iCode
    {
        public string decode(string decode)
        {
            Char[] charArray = decode.ToCharArray();
            StringBuilder sb = new StringBuilder();

            // Rotate the character by 13.
            foreach(Char ch in charArray){
                sb.Append((char)(ch - 13));
            }

            return sb.ToString();
        }


        
        public string encode(string uncoded)
        {
            Char[] charArray = uncoded.ToCharArray();
            StringBuilder sb = new StringBuilder();

            // Rotate the character by 13.
            foreach (Char ch in charArray) {
                sb.Append((char)(ch + 13));
            }
            
            return sb.ToString();
        }
    }
}
