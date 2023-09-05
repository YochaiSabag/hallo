using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp.utilities
{
    internal class Implementions
    {
        public static int ReverseNumbers(int num)
        {
            char[] charArray= num.ToString().ToCharArray();
            Array.Reverse(charArray);
           
            return Int32.Parse(new string(charArray));
        }
    }
}
